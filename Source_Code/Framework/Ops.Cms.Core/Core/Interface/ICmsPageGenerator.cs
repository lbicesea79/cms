﻿/*
* Copyright(C) 2010-2013 OPSoft Inc
* 
* File Name	: ICmsPageGenerator
* Author	: Newmin (new.min@msn.com)
* Create	: 2013/04/10 05:51:54
* Description	:
*
*/

using Ops.Cms.DataTransfer;

namespace Ops.Cms.Core.Interface
{
    public interface ICmsPageGenerator
    {
        /// <summary>
        /// 格式化模板路径
        /// </summary>
        /// <param name="tplPath"></param>
        /// <returns></returns>
        string FormatTemplatePath(string tplPath);

        /// <summary>
        /// 根据模板路径获取模板ID
        /// </summary>
        /// <param name="tplPath"></param>
        /// <returns></returns>
        string GetTemplateID(string tplPath);

        #region page

        /// <summary>
        /// 返回首页
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        string GetIndex(params object[] args);

        /// <summary>
        /// 栏目页
        /// </summary>
        /// <param name="category"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        string GetCategory(CategoryDto category, int pageIndex, params object[] args);

        /// <summary>
        /// 文档
        /// </summary>
        /// <param name="category"></param>
        /// <param name="archive"></param>
        /// <returns></returns>
        string GetArchive(ArchiveDto archive,params object[] args);

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        string GetSearch(params object[] args);

        
        /// <summary>
        /// 标签文档页
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        string GetTagArchive(params object[] args);

        #endregion

    }
}
