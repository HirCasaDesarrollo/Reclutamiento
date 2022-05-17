import React from "react";
import "./Courses.css";
import Card from "./Card/Card";
import leftRect from "../../images/rect-left.png";
import rightRect from "../../images/rect-right.png";
import profileLeft from "../../images/dianne.png";
import profileRight from "../../images/edwards.png";

function Courses() {
  return (
    <div className="container" style={{ width: "85%" }}>
      <h4>
        Your unfinished courses
        <span style={{ float: "right", fontSize: "2.5rem", color: "#DFDFE3" }}>
          ...
        </span>
      </h4>
      <div className="courses-container">
        <Card
          background={leftRect}
          img={profileLeft}
          name="Dianne Edwars"
          account="@dianeed"
          time="82min"
          text="Learning how to create simple Swift applications in 8 lessons"
        />
        <Card
          background={rightRect}
          img={profileRight}
          name="Dianne Edwars"
          account="@dianeed"
          time="90min"
          text="Best tips for drawing some good thematic illustration"
        />
      </div>
    </div>
  );
}

export default Courses;
