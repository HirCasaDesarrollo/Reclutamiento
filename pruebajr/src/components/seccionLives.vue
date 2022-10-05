<template>
    <div class="encabezado"> <h4>Lives lessons</h4><a href="#">●●●</a></div>
    <div class="contenedor">
        <div class="lives lvUno">
            <div class="live-Usuario usuUno">
                
            </div>
            <div class="isLive"><p>LIVE</p></div>
        </div>
        <div class="lives lvDos">
            <div class="live-Usuario usuDos"></div>
             <div class="isLive"><p>LIVE</p></div>
        </div>
        <div class="lives lvTres">
            <div class="live-Usuario usuTres"></div>
             <div class="isLive"><p>LIVE</p></div>
        </div>
        <div class="lives lvCuatro">
            <div class="live-Usuario usuCuatro"></div>
             <div class="isLive"><p>LIVE</p></div>
        </div>
        <div class="lives lvCinco">
            <div class="live-Usuario usuCinco"></div>
             <div class="isLive"><p>LIVE</p></div>
        </div>
        <div class="lives lvSeis">
            <div class="live-Usuario usuSeis"></div>
             <div class="isLive"><p>LIVE</p></div>
        </div>
        <div class="lives lvSiete">
            <div class="live-Usuario usuSiete"></div>
             <div class="isLive"><p>LIVE</p></div>
        </div>
         <div class=" verMas" ><a href="#">﹥</a></div>
    </div>
    
   
</template>

<script>
export default {
    name: 'SeccionLives'
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
    flex-wrap: wrap;
    width: 100%;
    height: 200px;
    padding: 0 130px;
 
}
.lives{
    display: flex;
    position: relative;
    margin: auto auto;
    border-radius: 20px;
    width: 150px;
    height: 100%;
    background-color: blue;
}
.live-Usuario{
    position: absolute;
    bottom: 20px;
    margin-left:auto;
    margin-right:auto;
    left:0;
    right:0;
    height: 100px;
    width: 100px;
    border-radius: 50%;
    border: solid 5px orangered;
    background-color: yellow;
}
.usuUno{
    background-image: url(../assets/imgLives/usu1.jfif);
    background-repeat: no-repeat;
    background-size: cover;  
}
.usuDos{
    background-image: url(../assets/imgLives/usu2.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}
.usuTres{
    background-image: url(../assets/imgLives/usu3.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}
.usuCuatro{
    background-image: url(../assets/imgLives/usu4.jfif);
    background-repeat: no-repeat;
    background-size: cover;  
}
.usuCinco{
    background-image: url(../assets/imgLives/usu5.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}
.usuSeis{
    background-image: url(../assets/imgLives/usu6.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}
.usuSiete{
    background-image: url(../assets/imgLives/usu7.jfif);
    background-repeat: no-repeat;
    background-size: cover;  
}




.lvUno{
    background-image: url(../assets/imgLives/live1.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}
.lvDos{
    background-image: url(../assets/imgLives/live2.jfif);
    background-repeat: no-repeat;
    background-size: cover;  
}
.lvTres{
    background-image: url(../assets/imgLives/live3.png);
    background-repeat: no-repeat;
    background-size: cover;  
}
.lvCuatro{
    background-image: url(../assets/imgLives/live4.jfif);
    background-repeat: no-repeat;
    background-size: cover;  
}
.lvCinco{
    background-image: url(../assets/imgLives/live5.jfif);
    background-repeat: no-repeat;
    background-size: cover;  
}
.lvSeis{
    background-image: url(../assets/imgLives/live6.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}
.lvSiete{
    background-image: url(../assets/imgLives/live7.jpg);
    background-repeat: no-repeat;
    background-size: cover;  
}

.isLive{
    display: flex;
    position: absolute;
    margin-left:auto;
    margin-right:auto;
    left:0;
    right:0;
    bottom: 15px;
    width: 50%;
    height: 30px;
    background-color: orangered;
}
P{
    margin: auto auto;
    font-weight: bold;
    color: white;
}
.verMas{
    display: flex;
    justify-content: center;
    align-items: center;
   
    width: 50px;

  
}
.verMas > a{
   
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
    height: 50px;
     border-radius: 15px;
    margin: 0;
    left: 0;
    color: black;
    box-shadow: 1px 1px 5px 1px whitesmoke;
    background-color: whitesmoke;
}
</style>