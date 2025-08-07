<?php include "nav.php" ?>
<main>
    <div class="container-calculator">
        <div class="frontpage-container">
            <div class="hero-content">
                <h1 class="hero-title" style=" color:rgb(4, 94, 129); text-shadow: none; ">Mikä on BMI-testi</h1>
                <p class="hero-subtitle" style="color: rgb(72, 71, 71); text-shadow: none;">BMI on mittaus, joka
                    suhteuttaa painon ja
                    pituuden. Se antaa karkean arvion
                    painon
                    sopivuudesta, mutta ei ota huomioon kehonkoostumusta.</p>
            </div>
        </div>
        <div class="info-container">
            <div class="calculator-container">
                <div class="row">
                    <div class="col-md-6">
                        <div class="calculator-table-container">
                            <table class="calculator-table">
                                <thead>
                                    <tr>
                                        <th>Luokitus</th>
                                        <th>Tulos</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr class="S-ali">
                                        <td>Sairaaloinen alipaino</td>
                                        <td>0-14,9</td>
                                    </tr>
                                    <tr class="M-ali">
                                        <td>Merkittävä alipaino</td>
                                        <td>15 – 17,9</td>
                                    </tr>
                                    <tr class="L-ali">
                                        <td>Lievä alipaino</td>
                                        <td>18 – 18,9</td>
                                    </tr>
                                    <tr class="norm">
                                        <td>Normaali paino</td>
                                        <td>19-24,9</td>
                                    </tr>
                                    <tr class="L-yli">
                                        <td>Lievä ylipaino</td>
                                        <td>25,0 – 29,9</td>
                                    </tr>
                                    <tr class="M-yli">
                                        <td>Merkittävä ylipaino</td>
                                        <td>30,0 – 34,9</td>
                                    </tr>
                                    <tr class="V-yli">
                                        <td>Vaikea ylipaino</td>
                                        <td>35,0 – 39,9</td>
                                    </tr>
                                    <tr class="S-yli">
                                        <td>Sairaalloinen ylipaino</td>
                                        <td>40,0 tai enemmän</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="bmi-calculator">
                            <div class="calculator-title">
                                <h3>Laskin</h3>
                            </div>
                            <div class="calculator-input">
                                <form action="Bmilaskuri.php" class="calculator form" method="post">
                                    <label for="pituus">Pituus</label>
                                    <input type="number" name="pituus" id="pituus" placeholder="cm">
                                    <label for="paino">Paino</label>
                                    <input type="number" name="paino" id="paino" placeholder="kg">
                                    <input type="submit" value="Laske">
                                </form>
                                <div class="calculator-result">
                                    <h3>Tulos: <span id="result"></span></h3>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<?php include "footer.php" ?>
<script>
    // Add this to your existing script section
    document.querySelector('form').addEventListener('submit', function (e) {
        e.preventDefault();
        const height = parseFloat(document.getElementById('pituus').value);
        const weight = parseFloat(document.getElementById('paino').value);

        if (height && weight) {
            const bmi = weight / ((height / 100) * (height / 100));
            const bmiRounded = bmi.toFixed(2);
            document.getElementById('result').textContent = bmiRounded;

            // Remove active class from all rows
            document.querySelectorAll('.calculator-table tbody tr').forEach(row => {
                row.classList.remove('active');
            });

            // Add active class to the appropriate row based on BMI
            if (bmi > 0 && bmi <= 14.9) {
                document.querySelector('.S-ali').classList.add('active');
            } else if (bmi >= 15 && bmi <= 17.9) {
                document.querySelector('.M-ali').classList.add('active');
            } else if (bmi >= 18 && bmi <= 18.9) {
                document.querySelector('.L-ali').classList.add('active');
            } else if (bmi >= 19 && bmi <= 24.9) {
                document.querySelector('.norm').classList.add('active');
            } else if (bmi >= 25 && bmi <= 29.9) {
                document.querySelector('.L-yli').classList.add('active');
            } else if (bmi >= 30 && bmi <= 34.9) {
                document.querySelector('.M-yli').classList.add('active');
            } else if (bmi >= 35 && bmi <= 39.9) {
                document.querySelector('.V-yli').classList.add('active');
            } else if (bmi >= 40) {
                document.querySelector('.S-yli').classList.add('active');
            }
        }
    });
</script>
</body>

</html>