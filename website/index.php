<?php
include "dbConfig.php";

//recupero i dati del ristorante
$sql = "SELECT *
        FROM info";
$result = $conn->query($sql);

if ($result->num_rows > 0)
    $info = $result->fetch_assoc();
$result->close();

//controllo se ci sono prodotti featured attivi adesso, così posso disabilitare la sezione dal top menù e dalla pagina
$sql = "SELECT cod_prodotto
        FROM prodotti
        WHERE featured=1
        ORDER BY cod_prodotto";
$attiva_feat=0;
$result = $conn->query($sql);

if ($result->num_rows > 0)
{
    $featured = array();
    $attiva_feat=1;
    while ($row = $result->fetch_assoc())
    {
        $featured[]=$row['cod_prodotto'];
    }
}
$result->close();
?>

<!DOCTYPE html>
<html>

    <head>
        <meta charset="UTF-8">
        <title><?php $info['nome_ristorante']; ?></title>
        <link rel="stylesheet" href="css/normalize.css">
        <link rel="stylesheet" href="css/main.css" media="screen" type="text/css">
        <link href='http://fonts.googleapis.com/css?family=Pacifico' rel='stylesheet' type='text/css'>
        <link href='http://fonts.googleapis.com/css?family=Playball' rel='stylesheet' type='text/css'>
        <link rel="stylesheet" href="css/bootstrap.css">
        <link rel="stylesheet" href="css/style-portfolio.css">
        <link rel="stylesheet" href="css/picto-foundry-food.css" />
        <link rel="stylesheet" href="css/jquery-ui.css">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/font-awesome.min.css" rel="stylesheet">
        <link rel="icon" href="favicon-1.ico" type="image/x-icon">
        <!-- google api -->
        <script type="text/javascript" src="goapp/go.js"></script>
        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js" ></script>
    </head>

    <body>

        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="row">
                <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">Restaurant</a>
                    </div>

                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav main-nav  clear navbar-right ">
                            <li><a class="navactive color_animation" href="#top">WELCOME</a></li>
                            <li><a class="color_animation" href="#story">ABOUT</a></li>
                            <li><a class="color_animation" href="#pricing">PRICING</a></li>
                            <!-- <li><a class="color_animation" href="#beer">BEER</a></li>
                            <li><a class="color_animation" href="#bread">BREAD</a></li> -->
                            <?php
                            if($attiva_feat==1)
                                echo "<li><a class='color_animation' href='#featured'>FEATURED</a></li>";
                            ?>
                            <li><a class="color_animation" href="#reservation">RESERVATION</a></li>
                            <li><a class="color_animation" href="#contact">CONTACT</a></li>
                        </ul>
                    </div><!-- /.navbar-collapse -->
                </div>
            </div><!-- /.container-fluid -->
        </nav>
         
        <div id="top" class="starter_container bg">
            <div class="follow_container">
                <div class="col-md-6 col-md-offset-3">
                    <?php
                    echo "<h2 class='top-title'>";
                            echo $info['nome_ristorante'];
                    echo "</h2>";
                    if(isset($info['slogan']))
                        echo "<h2 class='white second-title'>".$info['slogan']."</h2>";
                    ?>
                    <hr>
                </div>
            </div>
        </div>

<?php
//        <!-- ============ About Us ============= -->

        include "about.php";




//       <!-- ============ Pricing  ============= -->


        include "pricing.php";

/*
//        <!-- ============ Our Beer  ============= -->


        <section id ="beer" class="description_content">
            <div  class="beer background_content">
                <h1>Great <span>Place</span> to enjoy</h1>
            </div>
            <div class="text-content container"> 
                <div class="col-md-5">
                   <div class="img-section">
                       <img src="images/beer_spec.jpg" width="100%">
                   </div>
                </div>
                <br>
                <div class="col-md-6 col-md-offset-1">
                    <h1>OUR BEER</h1>
                    <div class="icon-beer fa-2x"></div>
                    <p class="desc-text">Here at Restaurant we’re all about the love of beer. New and bold flavors enter our doors every week, and we can’t help but show them off. While we enjoy the classics, we’re always passionate about discovering something new, so stop by and experience our craft at its best.</p>
                </div>
            </div>
        </section>


       <!-- ============ Our Bread  ============= -->


        <section id="bread" class=" description_content">
            <div  class="bread background_content">
                <h1>Our Breakfast <span>Menu</span></h1>
            </div>
            <div class="text-content container"> 
                <div class="col-md-6">
                    <h1>OUR BREAD</h1>
                    <div class="icon-bread fa-2x"></div>
                    <p class="desc-text">We love the smell of fresh baked bread. Each loaf is handmade at the crack of dawn, using only the simplest of ingredients to bring out smells and flavors that beckon the whole block. Stop by anytime and experience simplicity at its finest.</p>
                </div>
                <div class="col-md-6">
                    <img src="images/bread1.jpg" width="260" alt="Bread">
                    <img src="images/bread1.jpg" width="260" alt="Bread">
                </div>
            </div>
        </section>
*/
        
//        <!-- ============ Featured Dish  ============= -->

        if($attiva_feat==1)
            include "featured.php";

//        <!-- ============ Reservation  ============= -->
        //come controllo se è connesso??
    include "reservation.php";

//        <!-- ============ Contact Section  ============= -->

        include "contact.php";

?>
        <!-- ============ Footer Section  ============= -->

        <footer class="sub_footer">
            <div class="container">
                <div class="col-md-4"><p class="sub-footer-text text-center">&copy; <?php echo $info['nome_ristorante']; ?> 2014, Theme by <a href="https://themewagon.com/">ThemeWagon</a></p></div>
                <!--<div class="col-md-4"><p class="sub-footer-text text-center">Back to <a href="#top">TOP</a></p>
                </div>
                <div class="col-md-4"><p class="sub-footer-text text-center">Built With Care By <a href="#" target="_blank">Us</a></p></div>-->
            </div>
        </footer>

        <script type="text/javascript" src="js/jquery-1.10.2.min.js"> </script>
        <script type="text/javascript" src="js/bootstrap.min.js" ></script>
        <script type="text/javascript" src="js/jquery-1.10.2.js"></script>     
        <script type="text/javascript" src="js/jquery.mixitup.min.js" ></script>
        <script type="text/javascript" src="js/main.js" ></script>

<?php //mysqli_close($conn); 
$conn->close();?>

    </body>
</html>