﻿using System;
using DevExpress.Web.ASPxGridView;

public partial class EditingCapabilities : System.Web.UI.Page {
    protected void grid_DataBinding(object sender, EventArgs e) {
        (sender as ASPxGridView).ForceDataRowType(typeof(NorthwindModel.Categories));
    }
}