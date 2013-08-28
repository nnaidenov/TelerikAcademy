<?php get_header(); ?>

<div class="5grid-layout">
    <div class="row">
        <div class="9u">
            <div id="content">
                <section>
                    <?php
                    if (have_posts()):
                        while (have_posts()):
                            the_post();
                            ?>
                            <h1><?php the_title() ?></h1>

                            <p><?php the_content() ?></p>
                            <br/>
                            <?php edit_post_link('Edit', '', '<br>'); ?>
                            <p><?php the_tags(); ?></p>
                            <br/>
                            <?php
                            comments_template();

                            echo '<span class="move_page">';
                            next_post_link('%link');
                            echo '</span>
                                <span class="move_page">';
                            previous_post_link('%link');
                            echo '</span>';
                        endwhile;

                    endif;
                    ?>
                </section>
            </div>
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