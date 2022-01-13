<%@ Control Language="C#" AutoEventWireup="true" CodeFile="cobrancax.ascx.cs" Inherits="Cobranca_Cobrancax" %>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>    
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script> 
    <script src="js/bootnavbar.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0" crossorigin="anonymous">
    </script>
    <script>
        
        // Prevent closing from click inside dropdown
        $(document).on('click', '.dropdown-menu', function (e) {
        e.stopPropagation();
        });

        // make it as accordion for smaller screens
        if ($(window).width() < 992) {
        $('.dropdown-menu a').click(function(e){
            e.preventDefault();
            if($(this).next('.submenu').length){
                $(this).next('.submenu').toggle();
            }
            $('.dropdown').on('hide.bs.dropdown', function () {
            $(this).find('.submenu').hide();
        })
        });
        }
    </script>
    <style>
        @media (min-width: 594px){
            .dropdown-menu .dropdown-toggle:after{
                border-top: .3em solid transparent;
                border-right: 0;
                border-bottom: .3em solid transparent;
                border-left: .3em solid;
            }
            .dropdown-menu .dropdown-menu{
                margin-left:0; margin-right: 0;
            }
            .dropdown-menu li{
                position: relative;
            }
            .nav-item .submenu{ 
                display: none;
                position: absolute;
                left:100%; top:-7px;
            }
            .nav-item .submenu-left{ 
                right:100%; left:auto;
            }
            .dropdown-menu > li:hover{ background-color: #f1f1f1 }
            .dropdown-menu > li:hover > .submenu{
                display: block;
            }
        }

        .dropdown-menu {
            margin-top: 0;
        }
        .dropdown-menu .dropdown-toggle::after {
            vertical-align: middle;
            border-left: 4px solid;
            border-bottom: 4px solid transparent;
            border-top: 4px solid transparent;
        }
        .dropdown-menu .dropdown .dropdown-menu {
            left: 100%;
            top: 0%;
            margin:0 20px;
            border-width: 0;
        }
        .dropdown-menu .dropdown .dropdown-menu.left {
            right: 100%;
            left: auto;
        }

        .dropdown-menu > li a:hover,
        .dropdown-menu > li.show {
	        background-color: #f1f1f1;
	        color: black;
        }
        .dropdown-menu > li.show > a{
	        color: white;
        }

        @media (min-width: 768px) {
            .dropdown-menu .dropdown .dropdown-menu {
                margin:0;
                border-width: 1px;
            }
        }
    </style>


<div id="myNav" runat="server"/>