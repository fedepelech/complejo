<template>
<div class="p-0 m-0">
      <div class="flex p-0 m-0">
      <!-- Sidebar -->
      <div class="bg-primary border-right p-0 m-0" id="sidebar-wrapper" >
        <div class="sidebar-heading p-0 m-0">
        <img src="https://scontent.faep22-1.fna.fbcdn.net/v/t1.15752-0/p280x280/74426367_2467674503280489_2587992115401195520_n.jpg?_nc_cat=104&_nc_oc=AQk2II1stUDi9qPgreFF4mebLRvOGz5T1dXmymyLIthOtkjPvDTCh-HGoqwirflY0ng&_nc_ht=scontent.faep22-1.fna&oh=1257bf425242d6cebad44c96af5bc9ce&oe=5E57AA03" style="width: 100px; height: 100px;"/>
        </div>
        <div class="list-group list-group-flush">          
          <div>
            <div role="tablist">
              <b-button block href="#" v-b-toggle.accordion-1 variant="primary">Departamento</b-button>
              <b-collapse id="accordion-1"  accordion="my-accordion" role="tabpanel">
                <b-button-group  vertical>
                  <b-button   variant="primary">Informacion</b-button>                   
                </b-button-group>
              </b-collapse>

              <b-button block href="#" v-b-toggle.accordion-2 variant="primary">Reservas</b-button>

              <b-collapse id="accordion-2" accordion="my-accordion" role="tabpanel">
                <b-button-group vertical>
                  <b-button variant="primary">Reservar</b-button>
                  <b-button variant="primary">Total Ganado</b-button>
                  </b-button-group>
              </b-collapse>

              <b-button block href="#" v-b-toggle.accordion-3 variant="primary">Cliente</b-button>

              <b-collapse id="accordion-3" accordion="my-accordion" role="tabpanel">
                <b-button-group vertical>
                  <b-button variant="primary">Alquileres</b-button>
                </b-button-group>
              </b-collapse>
            </div>
          </div>
          </div>
          </div>
    </div>
</div>
</template>
