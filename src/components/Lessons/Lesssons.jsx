import React from "react";
import "./Lessons.css";
import CardLesson from "./Card/Card";
import bg1 from "../../images/lesson-1.png";
import bg2 from "../../images/lesson-2.png";
import bg3 from "../../images/lesson-3.png";
import bg4 from "../../images/lesson-4.png";
import bg5 from "../../images/lesson-5.png";
import bg6 from "../../images/lesson-6.png";
import bg7 from "../../images/lesson-7.png";
import user1 from "../../images/user-1.png";
import user2 from "../../images/user-2.png";
import user3 from "../../images/user-3.png";
import user4 from "../../images/user-4.png";
import user5 from "../../images/user-5.png";
import user6 from "../../images/user-6.png";
import user7 from "../../images/user-7.png";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faArrowRight } from "@fortawesome/free-solid-svg-icons";

function Lessons() {
  return (
    <div className="main-container">
      <h3>
        Live Lessons{" "}
        <span style={{ float: "right", fontSize: "2.5rem", color: "#DFDFE3" }}>
          ...
        </span>
      </h3>
      <div className="lessons-container">
        <CardLesson bg={bg1} user={user1} />
        <CardLesson bg={bg2} user={user2} />
        <CardLesson bg={bg3} user={user3} />
        <CardLesson bg={bg4} user={user4} />
        <CardLesson bg={bg5} user={user5} />
        <CardLesson bg={bg6} user={user6} />
        <CardLesson bg={bg7} user={user7} />
        <FontAwesomeIcon className="arrow-icon" icon={faArrowRight} />
      </div>
    </div>
  );
}

export default Lessons;
