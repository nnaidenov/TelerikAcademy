</div>
<div id="scroll">
        <a title="Scroll to the top" class="top" href="#"><img src="<?php echo get_template_directory_uri() ?>/images/top.png" alt="top" /></a>
    </div>
    <footer>
        <p><img src="<?php echo get_template_directory_uri() ?>/images/twitter.png" alt="twitter" />&nbsp;<img src="<?php echo get_template_directory_uri() ?>/images/facebook.png" alt="facebook" />&nbsp;<img src="<?php echo get_template_directory_uri() ?>/images/rss.png" alt="rss" /></p>
 <?php
                    $defaultsFooterNav = array(
                        'theme_location' => 'bottom-site-menu',
                        'menu' => '',
                        'container' => 'nav',
                        'container_class' => '',
                        'container_id' => 'footerMenu',
                        'menu_class' => '',
                        'menu_id' => '',
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

                    wp_nav_menu($defaultsFooterNav);
                    ?>        
<!--<a href="index.html">Home</a> | <a href="examples.html">Examples</a> | <a href="page.html">A Page</a> | <a href="another_page.html">Another Page</a> | <a href="contact.php">Contact Us</a></p>-->
<p>Copyright &copy; CSS3_trees | <a href="http://www.heartinternet.co.uk/web-hosting/">Web hosting</a> | <a href="http://www.css3templates.co.uk">design from css3templates.co.uk</a></p>
    </footer>
</div>
<!-- javascript at the bottom for fast page loading -->
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/jquery.easing-sooper.js"></script>
<script type="text/javascript" src="js/jquery.sooperfish.js"></script>
<script type="text/javascript">
    $(document).ready(function() {
        $('ul.sf-menu').sooperfish();
        $('.top').click(function() {$('html, body').animate({scrollTop:0}, 'fast'); return false;});
    });
</script>
</body>
</html>