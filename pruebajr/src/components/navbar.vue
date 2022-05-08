<template>
    <div class="contenedor">
        <div class="buscador">
            <i><a href=""><font-awesome-icon icon="magnifying-glass" /></a></i>
            <input type="text" placeholder="Search...">
        </div>
        <ul>
            <li><a href="#"><font-awesome-icon icon="user" /></a></li>
            <li  class="icono-Naranja"><a href="#"><font-awesome-icon icon="bell"/></a></li>
        </ul>
    </div>
</template>
<script>
export default {
    name : 'NavBar',
}
</script>

<style scoped>
.contenedor{
    position: relative;
    display: flex;
    justify-content: space-around;
    align-items: center;
    width: 100%;
    height: 100px;
    
}
.buscador{
    display: flex;
    position: relative;
    align-items: center;
    width: 85%;
    height: 30%;
    padding: 0 5% 0 5%;
    
}
.buscador i{
    display: flex;
    flex-flow: column;
    justify-content: center;
    font-size: 35px;
    width: 100px;
    height: 50px;
    border-top-left-radius: 25px;
    border-bottom-left-radius: 25px;
    background-color: whitesmoke;
}
.buscador > input{
    width: 100%;
    height: 50px;
    border-top-right-radius: 25px;
    border-bottom-right-radius: 25px;
    border: none;
    font-size: 30px;
    
    background-color: whitesmoke;
    
}

.contenedor > ul {
    display: flex;
    position: relative;
    align-items: center;
    list-style: none;
    margin-right: 130px;
   
}
.contenedor a {
    font-size: 35px;
     margin: 0 20px 0 20px;
     color: black;
}
.icono-Naranja{
    display: flex;
    position: relative;
    align-items: center;
    height: 50px;
    border-radius: 15px;
    background-color: rgba(255, 68, 0, 0.87);
}
</style>