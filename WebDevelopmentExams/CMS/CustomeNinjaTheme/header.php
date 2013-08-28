<!DOCTYPE HTML>
<html>
    <head>
        <title><?php echo wp_title(); ?></title>
        <meta http-equiv="content-type" content="text/html; charset=utf-8" />
        <meta name="description" content="" />
        <meta name="keywords" content="" />

        <link rel="stylesheet" href="<?php echo get_template_directory_uri() ?>/css/5grid/core.css" />
        <link rel="stylesheet" href="<?php echo get_template_directory_uri() ?>/css/5grid/core-desktop.css" />
        <link rel="stylesheet" href="<?php echo get_template_directory_uri() ?>/css/5grid/core-1200px.css" />
        <link rel="stylesheet" href="<?php echo get_template_directory_uri() ?>/css/5grid/core-noscript.css" /> 
        <link rel="stylesheet" type="text/css" href="<?php bloginfo('stylesheet_url'); ?>" />
<!--        <link rel="stylesheet" href="<?php echo get_template_directory_uri() ?>/css/style-desktop.css" />-->


        <script src="<?php echo get_template_directory_uri() ?>/css/5grid/jquery.js"></script>
        <script src="<?php echo get_template_directory_uri() ?>/css/5grid/init.js?use=mobile,desktop,1000px&amp;mobileUI=1&amp;mobileUI.theme=none"></script>

        <!--        [if IE 9]><link rel="stylesheet" href="css/style-ie9.css" /><![endif]-->
        <?php wp_head(); ?>
    </head><body>
        <div id="wrapper">
            <div id="header-wrapper">
                <header id="header">
                    <div class="5grid-layout">
                        <div class="row">
                            <div class="12u" id="logo"> <!-- Logo -->
                                <h1><a href="#" class="mobileUI-site-name"> <?php bloginfo('name'); ?></a></h1>
                            </div>
                        </div>
                    </div>

                    <div class="5grid-layout">
                        <div class="row">
                            <div class="12u" id="menu">
                                <div id="menu-wrapper">
                                    <?php
                                    /* Dynamic menu if available */
                                    if (!function_exists('wp_nav_menu')) {
                                        $args = array(
                                            'show_home' => true);
                                        wp_page_menu($args);
                                    } else {
                                        wp_nav_menu(array('theme_location' => 'main', 'fallback_cb' => 'fallbackmenu'));
                                    }
                                    ?>
                                </div>
                            </div>
                        </div>
                    </div>
                </header>
            </div>
            <div id="page-wrapper" class="5grid-layout">
                <div class="5grid-layout">
                    <div class="row">
                        <div class="12u">
                            <div id="banner"><a href="#"><img src="<?php echo get_theme_mod('logo_img');?>"></a></div>
                        </div>
                    </div>
                </div>