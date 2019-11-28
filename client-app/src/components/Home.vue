<template>
<div>
  <h1 class="display-3 font-weight-light mt-1 text-light text-center">Complejo Prisma</h1>
  <p class="lead text-dark text-center">Vacaciona en San Bernardo con tus amigos</p>
  <!-- <b-jumbotron header="COMPLEJO PRISMA" lead="Vacaciona en San Bernardo con tus amigos" class="body">
    <b-button variant="primary" href="#">More Info</b-button>
  </b-jumbotron> -->
  <!--<b-container>
    <b-row align-h='center' class='body'>
      <b-col cols=5>
        Complejo para jovenes pegado a Sanberchico. <br>
         Ubicado en Salta 2774. <br>
         Maximo 6 personas por depto. <br>
         Todas las noches se hace la previa entre los inquilinos. <br>
         Aceptamos tarjetas y MercadoPago.
      </b-col>
    </b-row>
  </b-container>-->
<div>
    <b-carousel
      id="carousel-1"
      v-model="slide"
      :interval="4000"
      controls
      indicators
      background="#ababab"
      img-width="1024"
      img-height="480"
      style="text-shadow: 1px 1px 2px #333;"
      @sliding-start="onSlideStart"
      @sliding-end="onSlideEnd"
    >
      <!-- Text slides with image -->
      <b-carousel-slide
        caption="Veni con tus amigos!!"
        text="Todas las noches previa y musica."
        img-src="../assets/image1.jpg"
      ></b-carousel-slide>

      <!-- Slides with custom text -->
      <b-carousel-slide img-src="../assets/image2.jpg">
        <h1>Ideal para Jovenes</h1>
      </b-carousel-slide>

      <!-- Slides with image only -->
      <b-carousel-slide img-src="../assets/image3.jpg">
      <h1>Boliche Eterno y Sanberchico</h1>
      </b-carousel-slide>
    </b-carousel>
  </div>
</div>
</template>

<script>
export default {};
</script>
  
<style>
@import url("https://fonts.googleapis.com/css?family=Lato|PT+Sans|Raleway|Roboto&display=swap");
.fondo {
  background: lightgray;
}

.body {
  background: white;
  font-family: "Lato", sans-serif;
}
.tittle{
    border-radius: 2rem;
    margin-bottom: 1rem;
    margin-top: 1rem;
}
</style>
