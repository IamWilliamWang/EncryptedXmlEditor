using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEditor
{
    public class Generator //四个参数
    {
        public Byte[] key = new Byte[16];
        public Byte[] iv = new Byte[16];
        public Byte[] message = new Byte[1024];
        public Byte[] ciphertext = new Byte[1024];
        public UInt64 msglength;

        /// <summary>
        /// 使用默认的密钥流生成Generator
        /// </summary>
        public Generator()
        {
            this.flushKey();
            this.flushIv();
            this.flushMessage();
            this.setDefaultMsglength();

        }

        /// <summary>
        /// 使用给定的密钥流生成Generator
        /// </summary>
        /// <param name="key"></param>
        public Generator(Byte[] key)
        {
            this.key = key;
            this.flushIv();
            this.flushMessage();
            this.setDefaultMsglength();

        }

        private void flushKey()
        {
            for (int i = 0; i < key.Count(); i++)
            {
                key[i] = 0;
            }
        }

        private void flushIv()
        {
            /*set the value of the key and iv*/
            for (int i = 0; i < 16; i++)
            {
                iv[i] = 0;
            }
        }

        private void flushMessage()
        {
            /*set the value of message to 0 so that the ciphertext contains the keystream*/
            for (int i = 0; i < 1024; i++) message[i] = 0;
        }

        private void setDefaultMsglength()
        {
            /*generate the first 1024 keystream bytes*/
            msglength = 1024;
        }
    }
}
