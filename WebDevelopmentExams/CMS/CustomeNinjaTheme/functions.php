<?php
$first_right_sidebar_args = array(
    'name' => 'first-right-sidebar',
    'description' => '',
    'class' => '',
    'before_widget' => '<section id="%1$s" class="style1">',
    'after_widget' => '</section>',
    'before_title' => '<h2 class="widgettitle">',
    'after_title' => '</h2>');

register_sidebar($first_right_sidebar_args);

$second_right_sidebar_args = array(
    'name' => 'second-right-sidebar',
    'id' => "left-sidebar",
    'description' => '',
    'class' => '',
    'before_widget' => '<section id="%1$s" class="style1">',
    'after_widget' => '</section>',
    'before_title' => '<h2 class="widgettitle">',
    'after_title' => '</h2>');

register_sidebar($second_right_sidebar_args);

//Footer sidebars

$first_footer_sidebar_args = array(
    'name' => 'first-footer-sidebar',
    'description' => '',
    'class' => '',
    'before_widget' => '<section id="%1$s" class="style4">',
    'after_widget' => '</section>',
    'before_title' => '<h2 class="widgettitle">',
    'after_title' => '</h2>');

register_sidebar($first_footer_sidebar_args);

$second_footer_sidebar_args = array(
    'name' => 'second-footer-sidebar',
    'id' => "footer-sidebar1",
    'description' => '',
    'class' => '',
    'before_widget' => '<section id="%1$s" class="style4">',
    'after_widget' => '</section>',
    'before_title' => '<h2 class="widgettitle">',
    'after_title' => '</h2>');

register_sidebar($second_footer_sidebar_args);

$third_footer_sidebar_args = array(
    'name' => 'third-footer-sidebar',
    'id' => "footer-sidebar2",
    'description' => '',
    'class' => '',
    'before_widget' => '<section id="%1$s" class="style4">',
    'after_widget' => '</section>',
    'before_title' => '<h2 class="widgettitle">',
    'after_title' => '</h2>');

register_sidebar($third_footer_sidebar_args);


register_nav_menus(array(
    'main' => __('Main Navigation', ''),
));

function fallbackmenu() {
    ?>
    <li> Go to Adminpanel > Appearance > Menus to create your menu. You should have WP 3.0+ version for custom menus to work.</li>
    <?php
}

function ninjaStyle_customizer_register($wp_customize) {

    $wp_customize->add_section('ninjaStyle_colors', array(
        'title' => __('Color', 'ninjaStyle'),
        'priority' => 120,
    ));

    $wp_customize->add_setting('link_color', array(
        'default' => '#D1551F',
        'transport' => 'refresh',
    ));
    $wp_customize->add_control(new WP_Customize_Color_Control($wp_customize, 'link_color', array(
        'label' => __('Link Color', 'ninjaStyle'),
        'section' => 'ninjaStyle_colors',
        'settings' => 'link_color'
    )));

    $wp_customize->add_setting('background_color', array(
        'default' => '',
        'transport' => 'refresh',
    ));
    $wp_customize->add_control(new WP_Customize_Color_Control($wp_customize, 'background_color', array(
        'label' => __('Background Color', 'ninjaStyle'),
        'section' => 'ninjaStyle_colors',
        'settings' => 'background_color'
    )));
    
    $wp_customize->add_setting('text_color', array(
        'default' => '#8A8A8A',
    ));
    $wp_customize->add_control(new WP_Customize_Color_Control($wp_customize, 'text_color', array(
        'label' => __('Text Color', 'ninjaStyle'),
        'section' => 'ninjaStyle_colors',
        'settings' => 'text_color'
    )));
    


    $wp_customize->add_section('ninjaStyle_images', array(
        'title' => __('Images', 'ninjaStyle'),
        'priority' => 120,
    ));
    $wp_customize->add_setting('logo_img', array(
        'default' => 'http://localhost/WP-Project/wp-content/themes/ninjaStyle/images/telerik-academy.png',
        'transport' => 'refresh',
    ));
    $wp_customize->add_control(new WP_Customize_Image_Control($wp_customize, 'logo_img', array(
        'label' => __('Logo Image', 'ninjaStyle'),
        'section' => 'ninjaStyle_images',
        'settings' => 'logo_img'
    )));
    
    
    $wp_customize->add_section('ninjaStyle_copyright', array(
        'title' => __('Copyright Details', 'ninjaStyle'),
    ));
    $wp_customize->add_setting('copyright_details', array(
        'default' => '&copy; Telerik CMS Course | Design: Telerik Software Academy',
    ));
    $wp_customize->add_control('copyright_details', array(
        'label' => __('Copyright information', 'ninjaStyle'),
        'section' => 'ninjaStyle_copyright',
        'settings' => 'copyright_details'
    ));
}

function ninjaStyle_customize_css() {
    ?>
    <style type="text/css">
        a { color: <?php echo get_theme_mod('link_color'); ?>; }
        p { color: <?php echo get_theme_mod('text_color'); ?>; }
        #wrapper { background: <?php echo get_theme_mod('background_color'); ?>; }
    </style>
    <?php
}

add_action('wp_head', 'ninjaStyle_customize_css');
add_action('customize_register', 'ninjaStyle_customizer_register');
