﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SageFrame.Web;

public partial class Modules_AspxCommerce_AspxGiftCardManagement_BalanceInquiry : BaseAdministrationUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IncludeJs("giftcardbalance", "/js/FormValidation/jquery.validate.js", "/js/DateTime/date.js");
        IncludeLanguageJS();
    }
}
