﻿using System;

namespace CTPCore
{
    /// <summary>
    /// 返回结果
    /// </summary>
    [Serializable]
    public class DataResult
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回代码
        /// </summary>
        public int ReturnCode { get; set; }
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    /// <typeparam name="T">结果对象类型</typeparam>
    [Serializable]
    public class DataResult<T>
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回代码
        /// </summary>
        public int ReturnCode { get; set; }
    }
}
