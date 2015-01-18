<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SoFTLibrary.Framework.UI.Login" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


<!DOCTYPE html>
<!--[if gte IE 9]>
<html class="no-js lt-ie9 no-animation animated-content" lang="en-US" prefix="og: http://ogp.me/ns#">     
<![endif]-->
<html lang="en"  prefix="og: http://ogp.me/ns#" class="animation-enabled animated-content colorize no-js">
<head runat="server">
    <title>SoFTLibrary</title>
    <meta charset="UTF-8" />
    <!-- Meta Tags -->
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />

		<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"> 
		<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
    <link href="Content/login-2015-01-04.css" rel="stylesheet" type='text/css' media='all' />
    <link href="Content/component.css" rel="stylesheet" />
    <script src="Scripts/modernizr.custom.js"></script>
    
<link rel='stylesheet' href='Content/bootstrap.css' type='text/css' media='all' />    
<link href="Content/Site.css" rel="stylesheet" type='text/css' media='all'/>
    
    <script type='text/javascript' src="Scripts/jquery.js"></script>
    <script type='text/javascript' src="Scripts/jquery-migrate.js"></script>
    <script type='text/javascript' src="Scripts/modernizr-2.6.2.js"></script>
</head>
<body class="home page page-id-6 page-template page-template-template-portfolio-php chrome osx wpb-js-composer js-comp-ver-3.6.2 vc_responsive">

<!-- Loading -->
<div id="loader-container">
	<span id="loader-percentage-line">
		<span id="loader-percentage"></span>
	</span>
</div>
<!-- End Loading -->

<!-- Start Wrap All -->
<div class="wrap_all content-wrapper">    <!-- Loader -->
<div class="page-bg"></div>
<div class="page-loader">
</div>
<!-- End Loader -->
    <!-- Start Main -->
        <div class="navbar">
            <div class="div-banner">
<%--            <img src="Images/text-header.png" alt="text-header" style="max-width: 100%!important"/>--%>
<%--                <span style="font-size: 36px;font-weight: bold;font-family: 'glyphicons-halflings-regular'">SOFTLibrary</span>
                <br/>
                <span style="font-size: 13px;font-family: 'Lato', sans-serif">SISTEM INFORMASI PERPUSTAKAAN, KATALOGISASI BERBASIS INDOMARC</span>
--%>            </div>
              <div class="la-anim-6">
			    <svg xmlns="http://www.w3.org/2000/svg" version="1.1" width="500" height="500" viewbox="0 0 500 500">
			      <path id="la-anim-6-border" transform="translate(250, 250)"/>
			      <path id="la-anim-6-loader" transform="translate(250, 250) scale(0.9)"/>
			    </svg>
		    </div>
            <div class="la-anim-1"></div>
        </div>
        <div class="div-container">
            <div class="div-login-container">
                    <div class="panel-heading">
                        <div class="panel-title">Sign In</div>
                    </div>     

                        <form id="loginform" class="form-horizontal" role="form" runat="server" novalidate>
                            <telerik:RadStyleSheetManager runat="server">
                            </telerik:RadStyleSheetManager>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            </telerik:RadAjaxManager>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Skin="Telerik"></telerik:RadWindowManager>                    
                            <div style="padding-top:10px" class="panel-body">

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                                                                
                            <div style="margin-bottom: 5px" class="input-group">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                        <asp:TextBox runat="server" ID="tbusername" CssClass="form-control" placeholder="username"></asp:TextBox>
                                    </div>
                                
                            <div style="margin-bottom: 5px" class="input-group">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-lock" style="width: 13px;"></i></span>
                                        <asp:TextBox runat="server" ID="tbpassword" CssClass="form-control" TextMode="Password" placeholder="password"></asp:TextBox>
                                    </div>

                                <div style="margin-top:5px" class="form-group">
                                    <div class="col-sm-12 controls">
                                        <asp:Button runat="server" CssClass="btn btn-success" ID="BtnLogin" Text="Login" OnClientClick="return ValidateInput()" OnClick="BtnLogin_OnClick"/>
                                        <br/>
                                        <span style="color: red;font-size: 9pt;"><asp:Literal runat="server" ID="ltMsg"></asp:Literal></span>
                                    </div>
                                </div>

                                <div style="margin-top:5px" class="form-group">
                                    <div class="col-sm-12">
                                        <br/>
                                    </div>
                                </div>
                                <div style="margin-top:5px" class="form-group">
                                    <div class="col-sm-12">
                                            <div style="text-align: center;font-size: 11px; color: #999;">
                                                © <%:DateTime.Now.Year %> <br />@softofucscenter.com
                                            </div> 
                                            </div> 
                                 </div>                     

                        </div>                     
                            </form>     

                 </div>  


      </div>
<script src="Scripts/classie.js"></script>
		<script>
		    var loader = document.getElementById('la-anim-6-loader')
		        , border = document.getElementById('la-anim-6-border')
		        , α = 0
		        , π = Math.PI
		        , t = 15

		        , tdraw;

		    function PieDraw() {
		        α++;
		        α %= 360;
		        var r = (α * π / 180)
		            , x = Math.sin(r) * 250
		            , y = Math.cos(r) * -250
		            , mid = (α > 180) ? 1 : 0
		            , anim = 'M 0 0 v -250 A 250 250 1 '
		                + mid + ' 1 '
		                + x + ' '
		                + y + ' z';

		        loader.setAttribute('d', anim);
		        border.setAttribute('d', anim);
		        if (α != 0)
		            tdraw = setTimeout(PieDraw, t); // Redraw
		    }

		    var inProgress = false;
		    setTimeout(function () {
		        classie.remove(animEl, 'la-animate');

		        if (anim === 'la-anim-6') {
		            PieReset();
		        }

		        inProgress = false;
		    }, 6000);
		    
		    window.addEventListener('load', function (e) {		      
		        PieDraw();
		    });
		</script>

</div>

 
<!-- End Wrap all -->
</body>
</html>

<script type='text/javascript' src="Scripts/plugins.js"></script>
<script type='text/javascript' src="Scripts/main-not-compiled.js"></script>
<script type="text/javascript">
    function ValidateInput() {
        var tbu = document.getElementById('<%=tbusername.ClientID%>').value;
        var tbp = document.getElementById('<%=tbpassword.ClientID%>').value;
        if (tbu == '') {
            window.radalert('Username harap di isi.', 350, 120, "Information", null, null);
            return false;
        }
        if (tbp == '') {
            window.radalert('Password harap di isi.', 350, 120, "Information", null, null);
            return false;
        }

        return true;
    }
</script>
