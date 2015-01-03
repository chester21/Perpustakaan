<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SoFTLibrary.Framework.UI.Login" %>


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
<%--<link rel='stylesheet' href='http://alessio86.bluxart.netdna-cdn.com/wp-content/themes/az/_include/css/bootstrap.min.css' type='text/css' media='all' />--%>
<link rel='stylesheet' href='http://alessio86.bluxart.netdna-cdn.com/wp-content/themes/az/style.css' type='text/css' media='all' />
<script type='text/javascript' src='http://alessio86.bluxart.netdna-cdn.com/wp-includes/js/jquery/jquery.js'></script>
<script type='text/javascript' src='http://alessio86.bluxart.netdna-cdn.com/wp-includes/js/jquery/jquery-migrate.min.js'></script>
<script type='text/javascript' src='http://alessio86.bluxart.netdna-cdn.com/wp-content/themes/az/_include/js/modernizr.js'></script>
<link rel='shortlink' href='http://www.alessioatzeni.com/?p=6' />

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
            <img src="Images/text-header.png" alt="text-header" style="max-width: 100%!important"/>
            </div>
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
<%--                 <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2" >--%>
                    <div class="panel-heading">
                        <div class="panel-title">Sign In</div>
                    </div>     

                    <div style="padding-top:10px" class="panel-body">

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                            
                        <form id="loginform" class="form-horizontal" role="form" runat="server">
                                    
                            <div style="margin-bottom: 5px" class="input-group">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                        <input id="loginUserId" type="text" class="form-control" name="username" value="" placeholder="username" runat="server" />
                                    </div>
                                
                            <div style="margin-bottom: 5px" class="input-group">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-lock" style="width: 13px;"></i></span>
                                        <input id="loginpassword" type="password" class="form-control" name="password" placeholder="password" runat="server" />
                                    </div>

                                <div style="margin-top:5px" class="form-group">
                                    <div class="col-sm-12 controls">
                                        <asp:Button runat="server" CssClass="btn btn-success" ID="BtnLogin" Text="Login"/>
                                        <br/>
                                        <span style="color: red;font-size: 9pt;"><asp:Literal runat="server" ID="ltMsg"></asp:Literal></span>
                                    </div>
                                </div>
                            </form>     
                        </div>                     
<%--                    </div>  --%>
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
<script type='text/javascript' src='http://alessio86.bluxart.netdna-cdn.com/wp-content/themes/az/_include/js/plugins.js'></script>
<script type='text/javascript' src='http://alessio86.bluxart.netdna-cdn.com/wp-content/themes/az/_include/js/main-not-compiled.js'></script>