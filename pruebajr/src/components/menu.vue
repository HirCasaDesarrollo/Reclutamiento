<template>
<div class="contenedor-menu">
   <div class="encabezado">
        <h1>E</h1><span>EduEra</span>
   </div>
   
      <ul>
        <li :class="{'cl-white' : colorHome, 'cl-reverse' : !colorHome}"  @click="home" ><i><font-awesome-icon icon="house-laptop" /></i><a href="#"  id="colorHome" > Home</a></li>
        <li :class="{'cl-white' : colorProgress, 'cl-reverse' : !colorProgress}" @click="progress"><i><font-awesome-icon icon="chart-simple" /></i><a href="#" id="colorProgress">Progress</a></li>
        <li :class="{'cl-white' : colorMessage, 'cl-reverse' : !colorMessage}" @click="message"><i><font-awesome-icon icon="comment" /></i><a href="#" id="colorMessages">Messages</a></li>
        <li :class="{'cl-white' : colorSettings, 'cl-reverse' : !colorSettings}" @click="settings"><i><font-awesome-icon icon="gear" /></i><a href="#" id="colorSettings">Settings</a></li>
      </ul>


    <section >
        <div class="bannerSoporte">
        <div class="bgprogramador"></div>
        <h3>Support 24/7</h3>
        <p>Contacts us anytime</p>
        <a href="#" class="btn-Contacto" >Start</a>
        <img src="../assets/img/1.png">
        </div>
    </section>
</div>
</template>

<script>




export default {
  name: 'HelloWorld',
  data(){
    return {
      colorPrincipal : true,
      colorHome : false,
      colorProgress : false,
      colorMessage : false,
      colorSettings : false,
    }
  },
  methods:{
    home(){
      document.getElementById('colorHome').style.color = "orange";
      document.getElementById('colorProgress').style.color = "";
      document.getElementById('colorMessages').style.color = "";
      document.getElementById('colorSettings').style.color = "";
      this.colorPrincipal = false,
      this.colorHome = true,
      this.colorProgress = false,
      this.colorMessage =false,
      this.colorSettings  =false
    },
    progress(){
      document.getElementById('colorProgress').style.color = "orange";
      document.getElementById('colorHome').style.color = "";
      document.getElementById('colorMessages').style.color = "";
      document.getElementById('colorSettings').style.color = "";
      this.colorHome = false,
      this.colorProgress = true,
      this.colorMessage =false,
      this.colorSettings  =false
    },
    message(){
      document.getElementById('colorMessages').style.color = "orange";
      document.getElementById('colorHome').style.color = "";
      document.getElementById('colorProgress').style.color = "";
      document.getElementById('colorSettings').style.color = "";
      this.colorHome = false,
      this.colorProgress = false,
      this.colorMessage =true,
      this.colorSettings  =false
    },
    settings(){
      document.getElementById('colorSettings').style.color = "orange";
      document.getElementById('colorHome').style.color = "";
      document.getElementById('colorProgress').style.color = "";
      document.getElementById('colorMessages').style.color = "";
      this.colorHome = false,
      this.colorProgress = false,
      this.colorMessage =false,
      this.colorSettings  =true
    },

    }
  }

</script>

<style scoped>
.clr{
  color: orange;
}
.cl-white {
  border-top-left-radius: 25px;
  border-bottom-left-radius: 25px;
  color: orange;
  background-color: white;
}
.cl-reverse{
   border-top-left-radius: 25px;
  border-bottom-left-radius: 25px;
  background-color: "";
}


.contenedor-menu{
    display: flex;
    position: relative;
    flex-direction: column;
    width: 100%;
    height: 100%;
    
}
.encabezado{
  display: flex;
  position: relative;
  width: 70%;
  align-items: center;
  margin-right: auto;
  margin-left: auto;
  top: 50px;

}
div h1 {
  margin: 10px;
  padding: 10px 15px 10px 15px;
  border-radius: 10px;
  
  color: whitesmoke;
  background-color: #5d4f9c;
}
 div span{
 font-size: 30px;
 font-weight: bold;
 padding: 0px 15px 0px 15px;
 color: whitesmoke;
}

ul{
  display: flex;
  position: relative;
 
  top: 9%;
  flex-direction: column;
  padding: 20px 0 0 40px;
  width: 100%;
  margin-left: auto;
  margin-right: auto;
  
   background-color: #503e9d;
}
ul > li,a{
  list-style: none;
  padding: 15px;
  margin: 20px 0 25px 0;
  text-align: left;
  text-decoration: none;

  color: white;
}




i{
   
  font-size: 20px;
  padding: 0px 25px 0px 0px;
}
section{
    display: flex;
    position: absolute;
    justify-content: center;
    bottom: 50px;
    width: 100%;
    
}
.bannerSoporte{
  position: relative;
  width: 70%;
  height: 300px;
  border-radius: 25px;
  background-color: #5d4f9c;
}
.bannerSoporte img{
    position: absolute;
    background-size: cover;
    right: 0;
    bottom: 0;
    max-height: 200px;
}
.bannerSoporte > h3, p{
    
    padding: 20px 20px 0px;
    text-align: left;
    color: whitesmoke;
}
.btn-Contacto{
    position: absolute;
    left: 20px;
    top: 100px;
    text-decoration: none;
	font-weight: bold;
	border-radius: 10px; 
	padding: 5px 20px; 

	color: whitesmoke;
    background-color: #ff4400; 
	box-shadow: 0px 8px 15px rgba(0, 0, 0, 0.1);

}
.bgprogramador{
    position: absolute;
    right: 0;
    bottom: 0;
    width: 200px;
    height: 180px;
    border-top-left-radius: 100%;
    border-top-right-radius: 30%;
    border-bottom-left-radius: 30%;
    border-bottom-right-radius: 35px;

    background-color: #6b5ab4;
}
</style>