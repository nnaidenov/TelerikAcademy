<?php
$sidebar_args = array(
    'id' => 'right-sidebar',
    'name' => 'Main sitebar',
    'description' => '',
    'class' => '',
    'before_widget' => '<ul id="%1$s" class="widget %2$s">',
    'after_widget' => '</ul>',
    'before_title' => '<h2 class="widgettitle">',
    'after_title' => '</h2>'
);

register_sidebar($sidebar_args);

register_nav_menu('top-site-menu', "This is my top menu!");
register_nav_menu('bottom-site-menu', "This is my top menu!");
?>
