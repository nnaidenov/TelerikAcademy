
</div>
<div class="5grid-layout 5grid">
    <div class="row" id="footer-content">
        <div class="6u" id="box1">
            <?php
            dynamic_sidebar('first-footer-sidebar');
            ?>
        </div>
        <div class="3u" id="box2">
            <?php
            dynamic_sidebar('second-footer-sidebar');
            ?>
        </div>
        <div class="3u" id="box3">
            <?php
            dynamic_sidebar('third-footer-sidebar');
            ?>
        </div>
    </div>
</div>
</div>
<div id="copyright" class="5grid-layout">
    <section>
        <p><?php echo get_theme_mod('copyright_details');?></p>
    </section>
</div>
</body>
</html>