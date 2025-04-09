<?php
session_start();
// Generate CSRF token if it doesn't exist
if (empty($_SESSION['csrf_token'])) {
    $_SESSION['csrf_token'] = bin2hex(random_bytes(32));
}
?>
<!DOCTYPE html>
<html lang="fi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Yhteystiedot</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="yhteistiedot.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <nav class="navbar navbar-default custom-navbar navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Crazy kuvat</a>
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse"
                    data-target="#navbarNavAltMarkup" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <ul class="nav navbar-nav">
                    <li><a href="index.html" class="smooth-scroll">Etusivu</a></li>
                    <li><a href="#" class="smooth-scroll">Hinnasto</a></li>
                    <li class="active"><a href="yhteistiedot.php">Yhteistiedot</a></li>
                </ul>
            </div>
        </div>
    </nav>
    
    <main style="padding-top: 70px;">
        <!-- Form section -->
        <div class="container">
            <section class="page-section">
                <form action="mailsender.php" method="post">
                    <!-- Add CSRF token as hidden field -->
                    <input type="hidden" name="csrf_token" value="<?php echo $_SESSION['csrf_token']; ?>">
                    
                    <h2>Ota yhteyttä</h2>
                    
                    <div class="form-row">
                        <div>
                            <label for="nimi">Nimi</label>
                            <input type="text" name="nimi" id="nimi" required>
                        </div>
                        
                        <div>
                            <label for="sahkoposti">Sähköposti</label>
                            <input type="email" name="sahkoposti" id="sahkoposti" required>
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <label for="viesti">Viesti:</label>
                        <textarea id="viesti" name="viesti" maxlength="150" rows="6" placeholder="kirjoita viesti..."></textarea>
                    </div>
                    
                    <button type="submit">Lähetä</button>
                </form>
            </section>
        </div>
        
        <div class="container">
            <section class="page-section">
                <h2 class="section-title">Yhteystiedot</h2>
                <div class="yhteistiedot-container">
                    <div>
                        <h2>Pekka</h2>
                        <h3>Puhelin numero</h3>
                        <p>044 98781234</p>
                        <h3>Sähköposti</h3>
                        <p>Pekkansahkoposti@gmail.com</p>
                        <img src="src/Pekka.jpg" alt="Pekka">
                    </div>
                    <div>
                        <h2>Ilkka</h2>
                        <h3>Puhelin numero</h3>
                        <p>044 12349898</p>
                        <h3>Sähköposti</h3>
                        <p>ilkansahkoposti@gmail.com</p>
                        <img src="src/ilkka.jpg" alt="Ilkka">
                    </div>
                </div>
            </section>
        </div>
    </main>
</body>
</html>