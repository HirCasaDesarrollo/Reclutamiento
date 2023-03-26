import style from "./About.module.css";



const About = () => {
  return (
    <div className={style.main}>
      <p>
        Soy Guillermo Rodríguez, soy Full Stack Developer con más de 3 años de experiencia como 
        Jefe de Unidad Departamental de Programación y Sistemas especializado en la gestión de 
        equipos y desarrollo de soluciones con ASP Clásico.
        Con conocimientos en desarrollo de aplicaciones Desktop y Web con C# bajo Visual Studio, 
        Javascript y React bajo Nodejs y manejo de diversos motores de bases de datos.
        Mi experiencia en creación de aplicaciones para agilizar los procesos administrativos y 
        el apoyo a la toma de decisiones, enfocado en resultados y la coordinación de equipos de desarrollo.
        Poseo un nivel intermedio del idioma inglés.
        <br />
      </p>
      <p>Está aplicación usa las siguientes tecnologías:</p>
      <ul className={style.list}>
        <li>
          React{" "}
          <img
            className={style.icontec}
            src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/2300px-React-icon.svg.png"
            alt="React"
          />
        </li>
        <li>
          Redux{" "}
          <img
            className={style.icontec}
            src="https://raw.githubusercontent.com/reduxjs/redux/master/logo/logo.png"
            alt="Redux"
          />
        </li>
        <li>
          Express{" "}
          <img
            className={style.icontec}
            src="https://w7.pngwing.com/pngs/925/447/png-transparent-express-js-node-js-javascript-mongodb-node-js-text-trademark-logo.png"
            alt="Express"
          />
        </li>
        <li>
          Sequelize{" "}
          <img
            className={style.icontec}
            src="https://cdn.iconscout.com/icon/free/png-256/sequelize-2-1175003.png"
            alt="Sequelize"
          />
        </li>
        <li>
          PostgreSQL{" "}
          <img
            className={style.icontec}
            src="https://user-images.githubusercontent.com/24623425/36042969-f87531d4-0d8a-11e8-9dee-e87ab8c6a9e3.png"
            alt="PostgreSQL"
          />
        </li>
        <li>
          Javascript{" "}
          <img
            className={style.icontec}
            src="https://cdn.iconscout.com/icon/free/png-256/javascript-2038874-1720087.png"
            alt="Javascript"
          />
        </li>
        <li>
          Css3{" "}
          <img
            className={style.icontec}
            src="https://cdn-icons-png.flaticon.com/512/5968/5968242.png"
            alt="Css"
          />
        </li>
        <li>
          Html5{" "}
          <img
            className={style.icontec}
            src="https://cdn-icons-png.flaticon.com/512/888/888859.png"
            alt="Html"
          />
        </li>
      </ul>
      <p>
        Está App tiene la funcionalidad de buscar pokemones que existan, 
        filtrar por lo que uno desee y también poder crear, modificar y eliminar pokemones.
      </p>
      <span>
        Esperemos cubrir con las espectativas.
      </span>
    </div>
  );
};
export default About;
