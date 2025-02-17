using UnityEngine;
namespace AES.Tools
{
    /// <summary>
    /// ��X�T���u��
    /// </summary>
    public class LogSystem
    {
        /// <summary>
        /// ��X�T���ë��w�C��
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string LogWithColor(string message,string color) 
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }

        /// <summary>
        /// ��X�T���ë��w�C��
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string LogWithColor(object message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }
    }
}

