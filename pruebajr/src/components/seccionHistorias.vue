<template>
<div class="encabezado"> <h4>Your Unfinished Courses</h4><a href="#" >●●●</a></div>
   
    <div class="contenedor">
        <div class="historia bgHst1">
            
            <div class="datosHistoria">
                <img src="../assets/img/mujerHistoriaUno.jpg">
                <div>
                <h5>Diana Edwads</h5>
                <span>@Diannod</span>
                </div>
                <p>82m</p>
            </div>
            <div class="descripcionHistoriaUno"><p>Learning how to create simple Swift application in 8 lesson</p></div>
        </div>
        <div class="historia bgHst2">
            <div class="datosHistoria">
                <img src="../assets/img/mujerHistoriaUno.jpg">
                <div>
                <h5>Diana Edwads</h5>
                <span>@Diannod</span>
                </div>
                <p>82m</p>
            </div>
            <div class="descripcionHistoriaDos"><p>Only best tips for drawing some good thematic illustration</p></div>
        </div>
    </div>
</template>

<script>
export default {
    name : "SeccionHistoria",
}
</script>

<style scoped>
.encabezado {
    display: flex;
    justify-content: space-between;
}

h4{
    display: flex;
    margin: 30px 130px;
    font-size: 30px;
}
a{
    
     margin: 30px 130px 0 0;
    padding: 0 10px;
    font-size: 30px;
    height: 30px;
    text-decoration: none;
    color: whitesmoke;
    text-shadow: 1.5px 1px  whitesmoke;
    
    
    
}
.contenedor{
    display: flex;
    position: relative;
    width: 100%;
    height: 400px;
    
}
.historia{
    display: flex;
    flex-direction: column;
    position: relative;
    float: right;
    margin: auto auto;
    border-radius: 70px;
    width: 500px;
    height: 100%;
    
    
    background-color: red;
}

.datosHistoria{
    display: flex;
    margin-top: 50px;
    margin-left: 20px;
    
}
.datosHistoria > div{
    margin: auto 0;
}
img{
    height: 100px;
    width: 100px;
    margin-right: 20px;
    border-radius: 50%;
}
h5{
    font-size: 25px;
    color: white;
    
}
span{
    display: flex;
    text-align: left;
    color: white;
  
}
.datosHistoria > p{
    display: flex;
    position: absolute;
    justify-content: center;
    align-items: center;
    margin-top: 25px;
    width: 50px;
    height: 25px;
    right: 20px;
    border-radius: 25px;
    color: white;
    background-color: orangered;
    
}

.descripcionHistoriaUno{
   
position: absolute;
	top: 80%;
	left: 50%;
	width: 80%;
	height: 70px; 
	margin-top: -35px; 
	margin-left: -40%;
    width: 80%;
    padding: 15px;
    color: white;
     border-radius: 20px;
   background-color: #5d4f9cb2;
 
    box-shadow: 1px 10px 15px 1px black;
}
.descripcionHistoriaDos{
    
    position: absolute;
    text-align: center;
	top: 80%;
	left: 50%;
	width: 80%;
	height: 70px; 
	margin-top: -35px; 
	margin-left: -40%;
    width: 80%;
    padding: 15px;
    color: white;
     border-radius: 20px;
   background-color: rgba(255, 0, 0, 0.685);
  
   box-shadow: 1px 10px 15px 1px black;
}

.bgHst1{
      background-image:url(../assets/img/mejorar.PNG);
      background-repeat: no-repeat;
       
      background-size: cover;  
}
.bgHst2{
      background-image:url(../assets/img/bgFondo2.PNG);
      background-repeat: no-repeat;
      
      background-size: cover;  
}
</style>