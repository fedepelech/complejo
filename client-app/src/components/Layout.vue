<template>
<body class="d-flex flex-column">
  <div id="page-content">
    <div class="container-fluid">
    <!-- FIRST ROW -->
    <div id="resulado"></div>
    <div class="row">
        <!-- NAVBAR -->
        <nav id="first_navbar" class="navbar navbar-light bg-light w-100">
            <span id="app" v-on:click="seen = !seen" class="control btn btn-outline-primary m-1"> X </span>
            <span class="text-black"><a class="navbar-brand ml-1 mt-0" href="#">Complejo Prisma</a></span>
        </nav>
        <!-- END NAVBAR -->
    </div>
    <!-- END FIRST ROW -->

    <!-- SECOND ROW -->
    <div class="row">
        <!-- FIRTS COL -->
        <div v-if="seen" class="col bg-danger" id="sidebar_width">
          <!-- COMPONENT SIDEBAR -->
          <Menu></Menu>
          <!--
          <h1 class="font-weight-light mt-4 text-white">Heimer</h1>
          <p class="lead text-white-50">"I require my adjustable reverse-ratcheting magnetic box wrench!"</p>
          END COMPONENT SIDEBAR 
          -->
        </div>
        <!-- END FIRST COL -->

        <!-- SECOND COL -->
        <div class="col" id="component_body">
          <!-- COMPONENT BODY ?? -->
          <!-- <h1 class="font-weight-light mt-4 text-white">Gangplank</h1>
          <p class="lead text-white-50">"You will never have a grave, Graves... see, it's 'cause your name, it's... your name is like a grave, it's never mind."</p>
          -->
          <Home> </Home>
          <!-- END COMPONENT BODY -->
        </div>
        <!-- END SECOND COL -->
    </div>
    <!-- END SECOND ROW -->

    </div>
  </div>

  <footer id="sticky-footer" class="py-4 bg-dark text-white-50">
    <div class="container text-center">
      <small>Copyright &copy; 2019 ~ <a href="http://localhost:8080/">ComplejoPrisma.com</a></small>
    </div>
  </footer>

</body>
</template>

<script>
import Home from './Home.vue'
import Menu from './Menu.vue'

export default {
    el: "home",
    components: {
      Home,
      Menu
    },
    data(){
      return{
        seen: false,
      }
    }
}
</script>

<style>
body {
  height: 100%;
}
#page-content {
  flex: 1 0 auto;
}
#sticky-footer {
  flex-shrink: none;
  bottom: 0;
  width: 100%;
}
#first_navbar{
 display:flow-root
}
#sidebar_width{
    max-width: 21%;
}
#component_body{
    max-width: 100%;
    margin-bottom: 1rem;
}
body {
  background: #007bff;
  background: linear-gradient(to right, #0062E6, #33AEFF);
}

</style>