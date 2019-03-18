using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEditor
{
    public class Encrypt
    {
        #region 最底层的代码，又原C代码直接翻译而来，请勿修改
        class HC128_State //define HC128_State structure
        {
            public UInt32[] P = new UInt32[512];
            public UInt32[] Q = new UInt32[512];
            public UInt32 counter1024;     /*counter1024 = i mod 1024 */
            public UInt32 keystreamword;   /*a 32-bit keystream word*/
        }
        //#defines
        UInt32 ROTR32(UInt32 x, int n)
        {
            return (((x) >> (n)) | ((x) << (32 - (n))));
        }
        UInt32 ROTL32(UInt32 x, int n)
        {
            return (((x) << (n)) | ((x) >> (32 - (n))));
        }
        UInt32 f1(UInt32 x)
        {
            return (ROTR32(x, 7) ^ ROTR32(x, 18) ^ (x >> 3));
        }
        UInt32 f2(UInt32 x)
        {
            return (ROTR32(x, 17) ^ ROTR32(x, 19) ^ (x >> 10));
        }

        /*g1 and g2 functions as defined in the HC-128 document*/
        UInt32 g1(UInt32 x, UInt32 y, UInt32 z)
        {
            return ((ROTR32((x), 10) ^ ROTR32((z), 23)) + ROTR32((y), 8));
        }
        UInt32 g2(UInt32 x, UInt32 y, UInt32 z)
        {
            return ((ROTL32((x), 10) ^ ROTL32((z), 23)) + ROTL32((y), 8));
        }


        /*function h1*/
        UInt32 h1(HC128_State state, UInt32 u)
        {
            UInt32 tem;
            Byte a, c;
            a = (Byte)((u));
            c = (Byte)((u) >> 16);
            tem = state.Q[a] + state.Q[256 + c];
            return (tem);
        }

        /*function h2*/
        UInt32 h2(HC128_State state, UInt32 u)
        {
            UInt32 tem;
            Byte a, c;
            a = (Byte)((u));
            c = (Byte)((u) >> 16);
            tem = state.P[a] + state.P[256 + c];
            return (tem);
        }

        /* one step of HC-128: 
           state is updated;
           a 32-bit keystream word is generated and stored in "state.keystreamword";
        */
        void OneStep(HC128_State state)
        {
            UInt32 i, i3, i10, i12, i511;

            i = state.counter1024 & 0x1ff;
            i3 = (i - 3) & 0x1ff;
            i10 = (i - 10) & 0x1ff;
            i12 = (i - 12) & 0x1ff;
            i511 = (i - 511) & 0x1ff;

            if (state.counter1024 < 512)
            {
                state.P[i] = state.P[i] + g1(state.P[i3], state.P[i10], state.P[i511]);
                state.keystreamword = h1(state, state.P[i12]) ^ state.P[i];
            }
            else
            {
                state.Q[i] = state.Q[i] + g2(state.Q[i3], state.Q[i10], state.Q[i511]);
                state.keystreamword = h2(state, state.Q[i12]) ^ state.Q[i];
            }
            state.counter1024 = (state.counter1024 + 1) & 0x3ff;
        }
        /* one step of HC-128 in the intitalization stage: 
           a 32-bit keystream word is generated to update the state;
         */
        void InitOneStep(HC128_State state)
        {
            UInt32 i, i3, i10, i12, i511;

            i = state.counter1024 & 0x1ff;
            i3 = (i - 3) & 0x1ff;
            i10 = (i - 10) & 0x1ff;
            i12 = (i - 12) & 0x1ff;
            i511 = (i - 511) & 0x1ff;

            if (state.counter1024 < 512)
            {
                state.P[i] = state.P[i] + g1(state.P[i3], state.P[i10], state.P[i511]);
                state.P[i] = h1(state, state.P[i12]) ^ state.P[i];
            }
            else
            {
                state.Q[i] = state.Q[i] + g2(state.Q[i3], state.Q[i10], state.Q[i511]);
                state.Q[i] = h2(state, state.Q[i12]) ^ state.Q[i];
            }
            state.counter1024 = (state.counter1024 + 1) & 0x3ff;
        }


        /*this function initialize the state using 128-bit key and 128-bit IV*/
        void Initialization(HC128_State state, UInt32[] key, Byte[] iv)
        {

            UInt32[] W = new UInt32[1024 + 256];
            int i;

            /*expand the key and iv into the state*/

            for (i = 0; i < 4; i++) { W[i] = key[i]; W[i + 1] = key[i]; }
            for (i = 0; i < 4; i++) { W[i + 2] = iv[i]; W[i + 3] = iv[i]; }

            for (i = 16; i < 1024 + 256; i++) W[i] = (UInt32)(f2(W[i - 2]) + W[i - 7] + f1(W[i - 15]) + W[i - 16] + i);

            for (i = 0; i < 512; i++) state.P[i] = W[i + 256];
            for (i = 0; i < 512; i++) state.Q[i] = W[i + 256 + 512];

            state.counter1024 = 0;

            /*update the cipher for 1024 steps without generating output*/
            for (i = 0; i < 1024; i++) InitOneStep(state);
        }

        /* this function encrypts a message*/
        void EncryptMessage(HC128_State state, Byte[] message, Byte[] ciphertext, UInt64 msglength)
        {
            UInt64 i;
            UInt32 j;
            int messageIndex = 0, ciphertextIndex = 0;

            /*encrypt a message, each time 4 bytes are encrypted*/
            for (i = 0; (i + 4) <= msglength; i += 4, messageIndex += 4, ciphertextIndex += 4)
            {
                /*generate 32-bit keystream and store it in state.keystreamword*/
                OneStep(state);

                {
                    /*encrypt 32 bits of the message*/

                    Byte[] ciphertextBytes = ConvertUtil.ConvertUInt32ToBytes(BitConverter.ToUInt32(message, messageIndex) ^ state.keystreamword);
                    for (int byteIndex = 0; byteIndex < 4; byteIndex++)
                        ciphertext[ciphertextIndex + byteIndex] = ciphertextBytes[byteIndex];
                }
            }
            /*encrypt the last message block if the message length is not multiple of 4 bytes*/
            if ((msglength & 3) != 0)
            {
                OneStep(state);
                for (j = 0; j < (msglength & 3); j++)
                {

                    ciphertext[j] = (byte)(message[j] ^ BitConverter.GetBytes(state.counter1024)[j]);

                }
            }
        }

        /* this function encrypts a message,
           there are four inputs to this function: a 128-bit key, a 128-bit iv, a message, the message length in bytes
           one output from this function: ciphertext
        */
        void stuffCiphertext(Byte[] key, Byte[] iv, Byte[] message, Byte[] ciphertext, UInt64 msglength)
        {
            HC128_State state = new HC128_State();

            /*initializing the state*/
            Initialization(state, ConvertUtil.ConvertBytesToUInt32s(key), iv);

            /*encrypt a message*/
            EncryptMessage(state, message, ciphertext, msglength);
        }
        #endregion
        Byte[] getCiphertext() //执行上述代码并返回密钥Byte[]
        {
            stuffCiphertext(generator.key, generator.iv, generator.message, generator.ciphertext, generator.msglength);
            return generator.ciphertext;
        }

        /// <summary>
        /// 对已有的明文进行加密，返回密文字节流
        /// </summary>
        /// <param name="明文"></param>
        /// <returns>密文</returns>
        public Byte[] executeEncoding(Byte[] 明文)
        {
            Byte[] keyStream = this.getCiphertext(); //执行HC128算法，获得密钥流
            Byte[] 密文 = new Byte[明文.Count()];
            for (int i = 0; i < 明文.Length; i++) //开始加密
            {
                密文[i] = 明文[i];
                密文[i] ^= keyStream[i % keyStream.Length];
            }
            return 密文;
        }

        /// <summary>
        /// 对已有的密文进行解密，返回明文字节流
        /// </summary>
        /// <param name="密文"></param>
        /// <returns>明文</returns>
        public Byte[] executeDecoding(Byte[] 密文)
        {
            return executeEncoding(密文);
        }

        public Encrypt(Generator generator)
        {
            this.generator = generator;
        }

        public static Byte[] defaultEncrypt(Byte[] input)
        {
            return new Encrypt(new Generator()).executeEncoding(input);
        }

        Generator generator; //储存getCiphertext函数所需要的几个参数，主要使用Generator.key
    }
}
