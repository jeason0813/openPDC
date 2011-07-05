﻿//******************************************************************************************************
//  DeviceUserControl.xaml.cs - Gbtc
//
//  Copyright © 2010, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  05/08/2011 - Mehulbhai P Thakkar
//       Generated original version of source code.
//
//******************************************************************************************************

using System.Windows.Controls;
using openPDCManager.UI.DataModels;
using openPDCManager.UI.WPF.ViewModels;

namespace openPDCManager.UI.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for DeviceUserControl.xaml
    /// </summary>
    public partial class DeviceUserControl : UserControl
    {
        #region [ Constructor ]

        /// <summary>
        /// Creates an instance of <see cref="DeviceUserControl"/> class.
        /// </summary>
        public DeviceUserControl()
            : this(null)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="DeviceUserControl"/> class.
        /// </summary>
        /// <param name="device"><see cref="Device"/> to be edited.</param>
        public DeviceUserControl(Device device)
        {
            InitializeComponent();
            this.Unloaded += new System.Windows.RoutedEventHandler(DeviceUserControl_Unloaded);
            if (device == null)
                this.DataContext = new Devices(0, false);
            else
                this.DataContext = new Devices(0, false, device);
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Handles unload event of the <see cref="DeviceUserControl"/>.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">Arguments for the event.</param>
        void DeviceUserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            (this.DataContext as Devices).ProcessPropertyChange();
        }

        #endregion
    }
}
