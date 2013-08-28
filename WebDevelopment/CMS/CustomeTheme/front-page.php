<?php get_header(); ?>

<div id="site_content">        
    <?php get_sidebar('right-sidebar') ?>
</div>

<div class="content">

    <?php
    if (have_posts()):
        while (have_posts()):
            the_post();
            ?>
            <h1><a href="<?php the_permalink() ?>"><?php the_title() ?></a></h1>
            <p><?php the_content() ?></p>
            <?php
        endwhile;
    endif;
    ?>
</div>

<?php get_footer(); ?>