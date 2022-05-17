import "./Sidebar.css";
import React from "react";
import computerImg from "../../images/computer.png";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faChartSimple,
  faComment,
  faGear,
  faHouse,
} from "@fortawesome/free-solid-svg-icons";

function Sidebar() {
  return (
    <div>
      <div
        id="sidebar-wrapper"
        className="d-flex flex-column flex-shrink-0 p-3 text-white  "
      >
        <a
          href="/"
          className="d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none"
        >
          <div className="fs-4 title">
            <span>E</span> Edu<span style={{ fontWeight: "normal" }}>Era</span>
          </div>
        </a>
        <ul className="sidebar-nav nav nav-pills flex-column mb-auto">
          <li>
            <a href="#" className="nav-link d-block active bg-white">
              <FontAwesomeIcon className="iconos" icon={faHouse} />
              Home
            </a>
          </li>
          <li>
            <a href="#" className="nav-link d-block text-white">
              <FontAwesomeIcon className="iconos" icon={faChartSimple} />
              Progress
            </a>
          </li>
          <li>
            <a href="#" className="nav-link d-block text-white  ">
              <FontAwesomeIcon className="iconos" icon={faComment} />
              Messages
            </a>
          </li>
          <li>
            <a href="#" className="nav-link d-block text-white  ">
              <FontAwesomeIcon className="iconos" icon={faGear} />
              Settings
            </a>
          </li>
        </ul>
        <div id="support-container">
          <h4>Support 24/7</h4>
          <p>contact us anytime</p>
          <button type="button" className="btn btn-primary">
            Start
          </button>
          <img src={computerImg} alt="" />
        </div>
      </div>
    </div>
  );
}

export default Sidebar;
