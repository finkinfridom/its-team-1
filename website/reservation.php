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
                                
                                    <script>
                                        function sendData(){
                                            var guest = jQuery('.guest').val();
                                            var datapicker = jQuery('.datapicker').val();
                                            jQuery.ajax({
                                                type: 'POST',
                                                url: 'ajax_orari.php',
                                                data: {
                                                    'guest': guest,
                                                    'datapicker': datapicker
                                                },
                                                success: function( data )
                                                {
                                                    var orari=$.parseJSON(data);
                                                    $.each(opts, function(i, d)
                                                    {
                                                        $('#hour').append('<option value="' + d.id_orari + '">' + d.ora + '</option>');
                                                    }
                                                }
                                            });
                                        }
                                    </script>
                                    <?php

                                    //if(isset($_SESSION['facebook_access_token']))
                                    $nome='marco';
                                    $cognome='marchi';
                                    $mail='pappapia@pappapia.it';
                                    if(true)
                                    {
                                    ?>
                                        <div class="col-lg-6 col-md-6 col-xs-6">
                                            <div><?php echo $nome; ?>, prenota in un attimo il tuo tavolo</div>                                        
                                            <!-- <input type='text' name='first_name' id='first_name' required='required' class='form' placeholder='First Name' value='".$nome."' readonly />
                                            <input type='text' name='last_name' id='last_name' required='required' class='form' placeholder='Last Name' value='".$cognome."' readonly />-->
                                            <input type='number' name='guest' id='guest' required='required' class='form' placeholder='Inserire numero di persone' min='1' max='25' onchange="sendData()" />
                                            <input type='date' name='datepicker' id='datepicker' required='required' class='form' min='<?php echo date('Y-m-d'); ?>' value='<?php echo date('Y-m-d'); ?>' onchange="sendData()"/>
                                            <!--<input type="text" name="hour" id="hour" required="required" class="form" placeholder="hh:mm" />-->
                                        </div>

                                        <div class="col-lg-6 col-md-6 col-xs-6">
                                            <input type="text" name="phone" id="phone" required="required" class="form" placeholder="Inserire numero di telefono" />
                                            <select name="hour" id="hour" class="form">
                                            
                                            </select>
                                            <?php
                                            echo "<input type='email' name='email' id='email' required='required' class='form' placeholder='Inserire un\'email valida'  value=".$mail." readonly />";
                                            ?>
                                            <!-- <input type="text" name="subject" id="subject" required="required" class="form" placeholder="Subject" /> -->
                                        </div>

                                        <div class="col-xs-6 ">
                                            <!-- Send Button -->
                                            <button type="submit" id="submit" name="submit" class="text-center form-btn form-btn">Reserve</button> 
                                        </div>
                                    <?php
                                    }
                                    else
                                    {
                                        echo "<p class='right-text'>Fai il login con il tuo account Google o Facebook.<br>
                                            Prenotando online potrai accumulare punti e accedere a sconti alla cassa.</p><br/>";

                                        include "vendor/fblogin.php";
                                        echo "<br/><br/>";
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