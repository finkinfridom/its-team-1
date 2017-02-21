<?php

$fb = new Facebook\Facebook([/* . . . */]);

$helper = $fb->getRedirectLoginHelper();
$permissions = ['email', 'user_location']; // optional
$loginUrl = $helper->getLoginUrl('http://localhost/ristorante/vendor/fblogin-callback.php', $permissions);

echo '<a href="' . $loginUrl . '">Log in with Facebook!</a>';
?>