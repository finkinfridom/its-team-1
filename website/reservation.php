<!-- ============ Reservation  ============= -->

<section  id="reservation"  class="description_content">
    <div class="featured background_content">
        <h1>Reserve a Table!</h1>
    </div>
    <div class="text-content container">
        <div class="inner contact">
            <!-- Form Area -->
            <div class="contact-form">
                <!-- Form -->
                <form id="contact-us" method="post" action="reserve.php">
                    <!-- Left Inputs -->
                    <div class="container">
                        <div class="row">
                            <div class="col-lg-8 col-md-6 col-xs-12">
                                <div class="row">
                                
                                    <?php
                                    $connessione=false;             //temporaneo per test
                                    $nome="Ciccio Pasticcio";   //temporaneo per test
                                    if($connessione==true)     //da rivedere cosa andrà qua dentro $connessione per ora non esiste
                                    {
                                        echo "<p class='right-text'>".ucfirst($nome).", prenota il tuo tavolo in pochissimi passaggi.</p>";
                                    ?> 

                                    <div class="col-lg-6 col-md-6 col-xs-6">
                                        <!-- Name -->
                                        <input type="text" name="first_name" id="first_name" required="required" class="form" placeholder="First Name" />
                                        <input type="text" name="last_name" id="last_name" required="required" class="form" placeholder="Last Name" />
                                        <input type="text" name="state" id="state" required="required" class="form" placeholder="State" />
                                        <input type="text" name="datepicker" id="datepicker" required="required" class="form" placeholder="Reservation Date" />
                                    </div>

                                    <div class="col-lg-6 col-md-6 col-xs-6">
                                        <!-- Name -->
                                        <input type="text" name="phone" id="phone" required="required" class="form" placeholder="Phone" />
                                        <input type="text" name="guest" id="guest" required="required" class="form" placeholder="Guest Number" />
                                        <input type="email" name="email" id="email" required="required" class="form" placeholder="Email" />
                                        <input type="text" name="subject" id="subject" required="required" class="form" placeholder="Subject" />
                                    </div>

                                    <div class="col-xs-6 ">
                                        <!-- Send Button -->
                                        <button type="submit" id="submit" name="submit" class="text-center form-btn form-btn">Reserve</button> 
                                    </div>
                                
                                    <?php
                                    }
                                    else
                                    {       
                                        //spi logins
                                        echo "<p class='right-text'>Fai il login con il tuo account Google o Facebook.<br>
                                                Prenotando online potrai accumulare punti e accedere a sconti alla cassa.</p><br/>";
                                        //GOOGLE
                                        include "goapp/index.html";
                                        //FACEBOOK
                                        ?>
                                        <div class="fb-login-button" data-max-rows="1" data-size="xlarge" data-show-faces="false" data-auto-logout-link="true"></div>
                                        <?php
                                        echo "<br/>";
                                        echo "<p>Oppure ordina con consegna a domicilio tramite Foodora</p><br/>
                                              <p class='right-text'><img src='images/foodora_btn_it.png' height=52px/></p><br/>";
                                        echo "<p class='right-text'>Non hai un account Google o Facebook?<br/>
                                                Contattaci al numero ".$info['telefono']." per effettuare una prenotazione telefonica</p><br/>";
                                    }
                                    ?>
                                </div>
                            </div>
                            
                            <div class="col-lg-4 col-md-6 col-xs-12">
                                <!-- Message -->
                                <div class="right-text">
                                    <h2>Hours</h2><hr>
                                    <?php
                                    function multiexplode ($delimiters,$string)
                                    {
                                        $ready = str_replace($delimiters, $delimiters[0], $string);
                                        $launch = explode($delimiters[0], $ready);
                                        return  $launch;
                                    }

                                    $orario=array_filter(multiexplode(array("\n","\r"), $info['orario']),'strlen');
                                    foreach ($orario as $value)
                                    {
                                        echo "<p>".$value."</p>";
                                    } 
                                    ?>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Clear -->
                    <div class="clear"></div>
                </form>
            </div><!-- End Contact Form Area -->
        <br/><p class='right-text'>Our app is now available on Google Play. Scaricala per avere più informazioni sul tuo utente e per prenotare da ovunque il tuo tavolo.</p>
        <p><img src='images/google-play-badge.png' height='52px'/><br/>
        <i>Google Play and the Google Play logo are trademarks of Google Inc.</i></p>
        </div><!-- End Inner -->
    </div>
</section>