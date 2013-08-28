<!DOCTYPE HTML>
<html>

    <head>
        <title>CSS3_trees</title>
        <meta name="description" content="website description" />
        <meta name="keywords" content="website keywords, website keywords" />
        <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
        <link rel="stylesheet" type="text/css" href="<?php bloginfo('stylesheet_url'); ?>" />
        <!-- modernizr enables HTML5 elements and feature detects -->
        <script type="text/javascript" src="<?php echo get_template_directory_uri() ?>/js/modernizr-1.5.min.js"></script>
    </head>
    <body>
        <div id="main">
            <header>
                <div id="logo">
                    <div id="logo_text">
                        <!-- class="logo_colour", allows you to change the colour of the text -->
                        <h1><a href="index.html">CCS3<span class="logo_colour">_trees</span></a></h1>
                        <h2>Simple. Contemporary. Website Template.</h2>
                    </div>
                </div>

                <nav>
                    <?php
                    $defaults = array(
                        'theme_location' => 'top-site-menu',
                        'menu' => '',
                        'container' => 'div',
                        'container_class' => '',
                        'container_id' => 'menu_container',
                        'menu_class' => 'sf-menu',
                        'menu_id' => 'nav',
                        'echo' => true,
                        'fallback_cb' => 'wp_page_menu',
                        'before' => '',
                        'after' => '',
                        'link_before' => '',
                        'link_after' => '',
                        'items_wrap' => '<ul id="%1$s" class="%2$s">%3$s</ul>',
                        'depth' => 0,
                        'walker' => ''
                    );

                    wp_nav_menu($defaults);
                    ?>
                </nav>
            </header>