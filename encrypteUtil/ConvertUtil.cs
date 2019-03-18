using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEditor
{
    public class ConvertUtil
    {
        public static Byte[] HexStrToBytes(String hexStr)
        {
            Byte[] key = new Byte[hexStr.Length / 2];
            for (int keyStringIndex = 0; keyStringIndex < hexStr.Length; keyStringIndex += 2)
            {
                key[keyStringIndex / 2] = Convert.ToByte(hexStr.Substring(keyStringIndex, 2), 16);
            }
            return key;
        }

        /// <summary>
        /// 将UInt32 转换成 Byte[]
        /// </summary>
        /// <param name="uintNumber"></param>
        /// <returns></returns>
        public static Byte[] ConvertUInt32ToBytes(UInt32 uintNumber)
        {
            Byte[] b = new Byte[4];
            b[0] = (byte)(uintNumber);
            b[1] = (byte)(uintNumber >> 8);
            b[2] = (byte)(uintNumber >> 16);
            b[3] = (byte)(uintNumber >> 24);
            return b;
        }

        /// <summary>
        /// 将Byte[] 转换成 UInt32[]
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static UInt32[] ConvertBytesToUInt32s(Byte[] bytes)
        {
            uint bytesLength = (uint)(bytes.Length);
            UInt32[] uInt32s = new UInt32[bytesLength / 4];
            for (int uInt32sIndex = 0; uInt32sIndex < bytesLength / 4; uInt32sIndex += 1)
            {
                UInt32 tp = BitConverter.ToUInt32(bytes, uInt32sIndex * 4);
                uInt32s[uInt32sIndex] = tp;
            }
            return uInt32s;
        }
    }
}
