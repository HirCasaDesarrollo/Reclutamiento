<template>
  <div class="bg">
  <div class="panel-izquierdo"><menuPanel/></div>
  <div class="panel-derecho"><navBar/><historias/><lives/></div>
  </div>
</template>

<script>
import menuPanel from '@/components/menu.vue'
import navBar from '@/components/navbar.vue'
import historias from '@/components/seccionHistorias.vue'
import lives from '@/components/seccionLives.vue'

export default {
  
  components: {
    
    menuPanel,
    navBar,
    historias,
    lives
  },
}
</script>


<style scoped>
.bg{
  display: flex;
  height: 100vh;

  background-color: #503e9d;
}
.panel-izquierdo{
  
  height: 100%;
  width: 20vw;

 background-color: #503e9d;
}
.panel-derecho{
  display: flex;
  flex-direction: column;
  margin: auto;
  border-radius: 50px;
  margin-left: 0;
  height: 95%;
  width: 78.5vw;
 
  background-color: white;
}

</style>