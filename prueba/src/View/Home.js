import { React } from "react";
import { Col, Row } from "react-bootstrap";
import '../Style/Style.scss';

class Home extends React.Component {
  render() {
    return (
      <>
        <div class='dashboard-app' id="Home">

          <div class='dashboard-content'>
            <div class='container'>
              <div class='card'>
                <div class='card-header'>
                  <h1>Welcome back Jim</h1>
                </div>
                <div class='card-body px-5'>
                  <Row>
                    <Col md="9">
                    <input />
                    </Col>
                    <Col md="3">
                    </Col>
                  </Row>

                </div>
              </div>
            </div>
          </div>
        </div>


      </>
    )
  }
}
export default Home;