﻿// <copyright file="IIncreasePersistenceQuotaDialog.cs" company="Microsoft Corporation">
// ===============================================================================
//
//
// Project: Microsoft Silverlight Rough Cut Editor
// FILES: IIncreasePersistenceQuotaDialog.cs                     
//
// ===============================================================================
// Copyright 2010 Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ===============================================================================
// </copyright>

namespace RCE.Modules.Settings.Views
{
    public interface IIncreasePersistenceQuotaDialog
    {
        void ShowDialog();

        void SetViewModel(object increasePersistenceQuotaViewModel);

        void CloseDialog();
    }
}
