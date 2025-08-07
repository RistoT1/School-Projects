<?php include "nav.php" ?>
<main>
    <div class="container-main">
        <div class="frontpage-img-container">
            <div class="hero-content">
                <h1 class="hero-title">Terveellisempää elämää liikkumalla</h1>
                <p class="hero-subtitle">Työkaluja ja tietoa hyvinvointisi tueksi</p>

                <div class="hero-buttons">
                    <a href="Bmilaskuri.php" class="hero-btn primary-btn">Aloita BMI-testi</a>
                    <a href="urheilulajit.php" class="hero-btn secondary-btn">Tutustu liikuntavinkkeihin</a>
                </div>

                <div class="hero-benefits">
                    <div class="benefit-item">
                        <i class="fas fa-heartbeat"></i>
                        <span>Paranna sydänterveyttä</span>
                    </div>
                    <div class="benefit-item">
                        <i class="fas fa-brain"></i>
                        <span>Vahvista mielen hyvinvointia</span>
                    </div>
                    <div class="benefit-item">
                        <i class="fas fa-dumbbell"></i>
                        <span>Kehitä voimaa ja kestävyyttä</span>
                    </div>
                </div>
            </div>
        </div>
        <div class="info-container">
            <div class="title">
                <h1>Tutustu myös näihin:</h1>
            </div>
            <div class="row">
                <div class="col-4">
                    <div class="infocard">
                        <div class="infocard-img"><img src="src/tietoaterveydesta.jpg" alt=""></div>
                        <div class="infocard-title">
                            <h2>Tietoaterveydestä</h2>
                        </div>
                        <div class="infocard-text">
                            <p>
                                Opi lisää terveydestäsi ja hyvinvoinnistasi! Saat helposti selkeää ja
                                käytännönläheistä tietoa, joka auttaa sinua tekemään parempia valintoja arjessa.
                            </p>
                        </div>
                        <div class="infocard-link">
                            <a href="tietoaterveydesta.php">Lue tästä</a>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="infocard">
                        <div class="infocard-img">
                            <img src="src/notebook.jpg" alt="notebook">
                        </div>
                        <div class="infocard-title">
                            <h2>Liikuntapäiväkirja</h2>
                        </div>
                        <div class="infocard-text">
                            <p>
                                Seuraa liikuntatottumuksiasi helposti digitaalisella liikuntapäiväkirjalla. Kirjaa
                                harjoitukset, asetetut tavoitteet ja edistymisesi – pysy motivoituneena ja näe
                                kehityksesi!
                            </p>
                        </div>
                        <div class="infocard-link">
                            <a href="liikuntapvkirja.php">Kirjota Liikuntapäiväkirjaa</a>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="infocard">
                        <div class="infocard-img"><img src="src/urheilulaji.jpg" alt=""></div>
                        <div class="infocard-title">
                            <h2>Tutustu urheilulajeihin</h2>
                        </div>
                        <div class="infocard-text">
                            <p>
                                Löydä itsellesi sopiva urheilulaji! Tutustu eri lajeihin, niiden hyötyihin ja löydä
                                uusi tapa liikkua ja parantaa hyvinvointiasi.
                            </p>
                        </div>
                        <div class="infocard-link">
                            <a href="urheilulajit.php">Lue tästä</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="question-section">
            <div class="row">
                <div class="col question-col">
                    <div class="title">
                        <h1>Usein kysyty kysymykset</h1>
                    </div>
                    <div class="question-container">
                        <div class="question" onclick="toggleAnswer(this)">
                            <h3>mikä on Askel-terveyssivusto?</h3><span><i class="fa-solid fa-plus"></i></span>
                        </div>
                        <div class="answer">
                            <p>Askel on hyvinvoinnin verkkosivusto, joka kannustaa liikkumaan arjessa – askel
                                kerrallaan. Sivustolta löydät luotettavaa perustietoa terveydestä, konkreettisia
                                vinkkejä liikkumisen lisäämiseen sekä helppoja keinoja seurata omaa aktiivisuuttasi.
                            </p>
                        </div>

                        <div class="question" onclick="toggleAnswer(this)">
                            <h3>Miten voin aloittaa arkiliikunnan harrastamisen?</h3><span><i
                                    class="fa-solid fa-plus"></i></span>
                        </div>
                        <div class="answer">
                            <p>Aloita pienestä! Kävele esimerkiksi osa työmatkasta, valitse portaat hissin sijaan
                                tai tee lyhyitä kävelylenkkejä päivän mittaan. On myös suositeltavaa hankkia arjen
                                ohelle liikuntapohjaisia harrastuksia. Niitä löydät esimerkiksi <a href="">Täältä.</a>
                            </p>
                        </div>

                        <div class="question" onclick="toggleAnswer(this)">
                            <h3>Mikä on normaali verenpaine?</h3><span><i class="fa-solid fa-plus"></i></span>
                        </div>
                        <div class="answer">
                            <p>Aikuisen normaali verenpaine on noin 120/80 mmHg. Yli 135/85 mmHg voi viitata
                                kohonneeseen
                                verenpaineeseen. Nuorilla normaali verenpaine on iästä ja pituudesta riippuen hieman
                                alempi kuin aikuisilla, mutta teini-iässä se lähestyy aikuisen normaalia tasoa.
                            </p>
                        </div>

                        <div class="question" onclick="toggleAnswer(this)">
                            <h3>Mikä on kehon painoindeksi (BMI) ja mitä se kertoo?</h3><span><i
                                    class="fa-solid fa-plus"></i></span>
                        </div>
                        <div class="answer">
                            <p>BMI on mittari, joka suhteuttaa painon ja pituuden. Se antaa karkean arvion painon
                                sopivuudesta, mutta ei ota huomioon kehonkoostumusta.
                            </p>
                        </div>

                        <div class="question" onclick="toggleAnswer(this)">
                            <h3>Mistä löydän luotettavaa terveystietoa netistä?</h3><span><i
                                    class="fa-solid fa-plus"></i></span>
                        </div>
                        <div class="answer">
                            <p>Luotettavia lähteitä ovat terveydenhuollon viralliset sivustot, kuten THL,
                                Terveyskirjasto ja lääkärien ylläpitämät palvelut.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="turha" style="padding: 150px;">

        </div>
    </div>
</main>
<?php include "footer.php" ?>
<script>
    function toggleAnswer(questionDiv) {
        const answerDiv = questionDiv.nextElementSibling;
        const icon = questionDiv.querySelector("i");

        answerDiv.classList.toggle("open");

        // Toggle icon class
        icon.classList.toggle("fa-plus");
        icon.classList.toggle("fa-minus");
    }
</script>
</body>

</html>