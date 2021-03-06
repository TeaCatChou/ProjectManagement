﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Views.Shared
{
    public class Link
    {
        //專案列表
        public static string Do = "Projects/Index?ProjectStatusID=1";
        public static string Check = "Projects/Index?ProjectStatusID=2";
        public static string Done = "Projects/Index?ProjectStatusID=3";
        //我的任務
        public static string Tasks = "SelectProject/Index";
        //成本管理
        public static string ExpList = "Cost/ExpList";
        public static string ExpCatMgr = "Cost/ExpCatMgr";
        public static string ExpChart = "Cost/Charts";
        public static string CostEstimation = "Cost/CostEstimation";
        //行事曆
        public static string Calendar = "Calendar/Index";
        //文件管理
        public static string Document = "Document/Index";
        public static string Document_Edit = "Document/Delete";
        //專案評分
        public static string Perfomance = "Perfomance/Index";
        public static string ChoseProject = "Perfomance/ChoseProject";
        //後臺管理
        public static string BackStage_Project = "ProjectsBackside/Index";
        public static string BackStage_ProjectCategory = "ProjectCategory/Index";
        public static string BackStage_ProjectStatus = "ProjectStatus/Index";
        public static string BackStage_Tasks = "#";
        public static string BackStage_TaskStatus = "TaskStatus/Index";
        public static string BackStage_Employees = "Employees/Index";
        public static string BackStage_Members = "Members/Index";
        public static string BackStage_JobTitle = "JobTitle/Index";
        public static string BackStage_Department = "Department/Index/";
        public static string BackStage_Permissions = "Permissions/Index";
        public static string BackStage_ProjectMembers = "ProjectMBackside/Index";
        //修改密碼
        public static string ChangePassword = "Members/Edit";
        //登出
        public static string Logout = "Members/Edit";
        //儀錶板
        public static string Dashboard = "Home/Index";
    }
}