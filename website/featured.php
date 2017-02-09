<!-- ============ Featured Dish  ============= -->

<section id="featured" class="description_content">
    <div  class="featured background_content">
        <h1>Our Featured Dishes <span>Menu</span></h1>
    </div>
    <div class="text-content container"> 
        <div class="col-md-6">
            <h1>Have a look to our dishes!</h1>
            <div class="icon-hotdog fa-2x"></div>
            <p class="desc-text">Each food is handmade at the crack of dawn, using only the simplest of ingredients to bring out smells and flavors that beckon the whole block. Stop by anytime and experience simplicity at its finest.</p>
        </div>
        <div class="col-md-6">
            <ul class="image_box_story2">
                <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">

                        <?php
                        for($i=0; $i<count($featured); $i++)
                        {
                            echo "<li data-target='#carousel-example-generic' data-slide-to='".$i."'"; if($i==0) echo " class='active'"; echo"></li>";
                        }
                        ?>

<!--                         <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                        <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                        <li data-target="#carousel-example-generic" data-slide-to="2"></li> -->
                    </ol>

                    <!-- Wrapper for slides -->
                    <div class="carousel-inner">

                        <?php
                        for($i=0; $i<count($featured); $i++)
                        {
                            echo "<div class='item"; if($i==0) echo " active"; echo "'>
                            <img src='images/slider".$featured[$i].".jpg'  alt='...'>
                            <div class='carousel-caption'>
                                        
                            </div>
                        </div>";
                        }
                        ?>

                        <!-- <div class="item active">
                            <img src="images/slider1.jpg"  alt="...">
                            <div class="carousel-caption">
                                        
                            </div>
                        </div>
                        <div class="item">
                            <img src="images/slider2.jpg" alt="...">
                            <div class="carousel-caption">
                                        
                            </div>
                        </div>
                        <div class="item">
                            <img src="images/slider3.JPG" alt="...">
                            <div class="carousel-caption">
                                        
                            </div>
                        </div> -->
                    </div>
                </div>
            </ul>
        </div>
    </div>
</section>