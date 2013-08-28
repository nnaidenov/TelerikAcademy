<?php get_header(); ?>

<div class="5grid-layout">
    <div class="row">
        <div class="6u">
            <div id="content">
                <?php
                if (have_posts()):
                    while (have_posts()):
                        the_post();
                        ?>
                        <section>
                            <h1><a href="<?php the_permalink() ?>"><?php the_title() ?></a></h1>
                            <p><?php the_content("read full article") ?></p>
                        </section>
                        <?php
                    endwhile;
                    ?>
                    <span class="move_page"><?php next_posts_link('Older'); ?></span>
                    <span class="move_page"><?php previous_posts_link('Newer'); ?></span>
                    <?php
                endif;
                ?>
            </div>
        </div>
        <div class="3u" id="sidebar1">
            <?php
            dynamic_sidebar('first-right-sidebar');
            ?>
        </div>
        <div class="3u">
            <div id="sidebar2">
                <?php
                dynamic_sidebar('second-right-sidebar');
                ?>
            </div>
        </div>
    </div>
</div>

<?php get_footer(); ?>