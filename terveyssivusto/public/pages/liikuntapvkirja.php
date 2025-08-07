<body class="page-paivakirja">
    <?php include __DIR__ . "/../partials/nav.php"; ?>
    <main>
        <div class="container paivakirja-container">
            <div class="input-section">
                <h2>Lisää harjoitus</h2>
                <form action="../api/saveExercise.php" id="exercise-form" method="post">
                    <div class="form-group">
                        <label for="date">Päivämäärä:</label>
                        <input type="date" name="date" id="date" required>
                    </div>

                    <div class="form-group">
                        <label for="activity">Harjoituksen tyyppi:</label>
                        <select name="activity" id="activity" required>
                            <option value="">Valitse harjoituksen tyyppi</option>
                            <option value="Juoksu">Juoksu</option>
                            <option value="Kävely">Kävely</option>
                            <option value="Pyöräily">Pyöräily</option>
                            <option value="Uinti">Uinti</option>
                            <option value="Voimaharjoittelu">Voimaharjoittelu</option>
                            <option value="Jooga">Jooga</option>
                            <option value="Venyttely">Venyttely</option>
                            <option value="Ryhmäliikunta">Ryhmäliikunta</option>
                            <option value="Muu">Muu</option>
                        </select>
                    </div>

                    <div class="form-group">
                        <label for="duration">Kesto (minuutteina):</label>
                        <input type="number" name="duration" id="duration" min="1" required>
                    </div>

                    <div class="form-group">
                        <label for="intensity">Intensiteetti:</label>
                        <select name="intensity" id="intensity" required>
                            <option value="">Valitse intensiteetti</option>
                            <option value="Kevyt">Kevyt</option>
                            <option value="Kohtalainen">Kohtalainen</option>
                            <option value="Raskas">Raskas</option>
                            <option value="Erittäin raskas">Erittäin raskas</option>
                        </select>
                    </div>

                    <div class="form-group">
                        <label for="notes">Lisätietoja:</label>
                        <textarea name="notes" id="notes"
                            placeholder="Kirjoita tähän lisätietoja harjoituksestasi..."></textarea>
                    </div>

                    <button type="submit" class="tallenna-btn">Tallenna harjoitus</button>
                </form>
            </div>

            <div class="entry-list">
                <div class="entry-container">
                    <div class="entry">
                        <h3>Luodut harjoitukset:</h3>
                        
                    </div>
                </div>
            </div>
        </div>
    </main>
    <?php include __DIR__ . '/../partials/footer.php';?>
    <script type="module" src="../js/main.js"></script>
</body>

</html>