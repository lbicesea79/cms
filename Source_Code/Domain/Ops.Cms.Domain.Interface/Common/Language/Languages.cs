﻿/*
* Copyright(C) 2010-2013 OPSoft Inc
* 
* File Name	: Languages.cs
* Author	: Newmin (new.min@msn.com)
* Create	: 2013/05/21 19:59:54
* Description	:
*
*/

namespace Ops.Cms.Domain.Interface.Common.Language
{

    /// <summary>
    /// 语言
    /// </summary>
    public enum Languages : int
    {
        /// <summary>
        /// 未知语言
        /// </summary>
        Unknown=0,

        /// <summary>
        /// 中文简体(Chinese Simplified)
        /// </summary>
        Zh_CN = 1,


        /// <summary>
        /// 中文繁体(Chinese Traditional)
        /// </summary>
        Zh_TW = 4,

        /// <summary>
        /// 英语(Unit States)
        /// </summary>
        En_US = 2,

        /// <summary>
        /// 西班牙语
        /// </summary>
        Es = 3,

        /// <summary>
        /// 泰语(ภาษาไทย)
        /// </summary>
        Thai = 5

    }
}
