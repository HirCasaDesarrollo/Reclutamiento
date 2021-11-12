import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { faCog, faComment, faHome, faSearch, faTasks, faUser } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import A1 from '../Img/Imagen1.png';
import A2 from '../Img/Campana.png';
import A3 from '../Img/Imagen2.png';
import A4 from '../Img/Imagen3.png';
import Img1 from '../Img/r1.png';
import Img2 from '../Img/r2.png';
import Img3 from '../Img/r3.png';
import Img4 from '../Img/r4.png';
import Img5 from '../Img/r5.png';
import Img6 from '../Img/r6.png';
import Img7 from '../Img/r7.png';
import Puntos from '../Img/puntos.png';
import Boton1 from '../Img/boton1.png';
import '../Style/Style.scss';
import { Col, Row } from 'react-bootstrap';


class Menu extends React.Component {

  render() {
    return (
      <>
        <div className="fondo container-fluid" >
          <div class='dashboard'>
            <div class="dashboard-nav">
              <header>

                <h4 style={{ color: 'white' }}> <span><b>Edu</b>Era</span></h4></header>
              <nav class="dashboard-nav-list">
                <br /><br /><br /><br />
                <a href="" class="dashboard-nav-item active nav-link" style={{ color: '#fb8155' }}><FontAwesomeIcon icon={faHome} /> &nbsp;Home</a>
                {/* <Link to={"/Home"} class="dashboard-nav-item">Home</Link> */}
                <a href="#" class="dashboard-nav-item  nav-link" style={{ color: '#fb8155' }}><FontAwesomeIcon icon={faTasks} /> &nbsp;Progress</a>
                <a href="#" class="dashboard-nav-item nav-link" style={{ color: '#fb8155' }}><FontAwesomeIcon icon={faComment} />&nbsp; Messages </a>
                <a href="#" class="dashboard-nav-item nav-link" style={{ color: '#fb8155' }}><FontAwesomeIcon icon={faCog} />&nbsp; Setting </a>

              </nav>
              <br /><br /><br />
              <img src={A1} className="px-5" />
            </div>
            <div class='dashboard-app px-5' id="Home">

              <div class='dashboard-content'>
                <div class='container'>
                  <div class='card'>

                    <div class='card-body px-5'>
                      <Row>

                        <Col md="10">
                          <div className="input-group pt-2">
                            <div className="input-group-append">
                              <span className="input-group-text"><FontAwesomeIcon icon={faSearch}></FontAwesomeIcon></span>
                            </div>
                            <input type="search" className="col-md-11" />
                          </div>
                        </Col>
                        <Col md="2" >
                          <div className="px-0" align="right">
                            <FontAwesomeIcon icon={faUser} />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <img src={A2} width="45%" />
                          </div>
                        </Col>
                      </Row>
                      <br /><br />
                      <h2>Your unfinished course <img src={Puntos} className="pt-2" align="right"/></h2>
                      <br />
                      <Row>
                        <Col md="6">
                          <div className="card border-0 contenedor">
                            <img src={A3} className="image" width="100%" alt="image_responsive" />
                          </div>
                        </Col>
                        <Col md="6">
                          <div className="card border-0 contenedor">
                            <img src={A4} width="100%" alt="image_responsive" className="image" />
                          </div>
                        </Col>
                      </Row>
                      <br />


                      <div>
                      <h3>Live lessons <img src={Puntos} className="pt-2" align="right"/> </h3>
                      </div>
                      <br />
                    


                      <div id="carouselExampleFade" class="carousel slide carousel-fade " data-bs-ride="carousel">
                        <div class="carousel-inner ">
                       
                            <div class="carousel-item active " >
                              <img src={Img1} alt="First slide" className="px-1 " />
                            <img src={Img2} alt="First slide" className="px-2" />
                            <img src={Img3} alt="First slide" className="px-2" />
                            <img src={Img4} alt="First slide" className="px-2" />
                            <img src={Img5} alt="First slide" className="px-2" />
                            <img src={Img6} alt="First slide" className="px-2" />
                            <img src={Img7} alt="First slide" className="px-2" />
                            </div>
                            <div class="carousel-item">
                            <img src={Img2} alt="First slide" className="px-1" />
                            <img src={Img4} alt="First slide" className="px-2" />
                            <img src={Img1} alt="First slide" className="px-2" />
                            <img src={Img7} alt="First slide" className="px-2" />
                            <img src={Img6} alt="First slide" className="px-2" />
                            <img src={Img5} alt="First slide" className="px-2" />
                            <img src={Img3} alt="First slide" className="px-2" />
                            </div>
                            
                          
                        </div>
                 
                        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">

                          <img src={Boton1} className="" alt="" />
                          <span class="visually-hidden">Next</span>
                        </button>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </>
    )
  }
}
export default Menu;