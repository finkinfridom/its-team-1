

<!-- ============ Pricing  ============= -->


<section id ="pricing" class="description_content">
    <div class="pricing background_content">
        <h1><span>Affordable</span> pricing</h1>
    </div>
    <div class="text-content container"> 
        <div class="container">
            <div class="row">
                <div id="w">
                    <ul id="filter-list" class="clearfix">
                        <li class="filter" data-filter="all">All</li>

                        <?php
                        $sql = "SELECT nome_cat
                                FROM categoria
                                ORDER BY nome_cat";
                                
                        $result = $conn->query($sql);
                        // output data of each row
                        if ($result->num_rows > 0)
                        {
                            //output of each row
                            while ($row = $result->fetch_assoc())
                            {
                                echo "<li class='filter' data-filter='" . $row['nome_cat'] . "'>" . ucfirst($row['nome_cat']) . "</li>";
                            }
                        }
                        $result->close();
                        ?>

                    </ul><!-- @end #filter-list -->    
                    <ul id="portfolio">

                        <?php
                        $sql = "SELECT cod_prodotto, nome_cat, prezzo
                                FROM prodotti
                                WHERE nel_menu=1
                                ORDER BY nome_prod";
                                
                        $result = $conn->query($sql);
                        // output data of each row
                        if ($result->num_rows > 0)
                        {
                            //output of each row
                            while ($row = $result->fetch_assoc())
                            {
                                echo "<li class='item " . $row['nome_cat'] . "'><img src='images/food_icon" . $row['cod_prodotto'] . ".jpg' alt='Food' >
                                    <h2 class='white'>€" . $row['prezzo'] . "</h2>
                                </li>";
                            }
                        }
                        $result->close();
                        ?>

                    </ul><!-- @end #portfolio -->
                </div><!-- @end #w -->
            </div>
        </div>
    </div>  
</section>