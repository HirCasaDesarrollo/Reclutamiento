import React from "react";
import "./Card.css";

function CardLesson({ bg, user }) {
  return (
    <div
      className="card-lessons-container"
      style={{ backgroundImage: `url(${bg})` }}
    >
      <div className="circle">
        <img src={user} alt="" />
      </div>
      <div className="live">LIVE</div>
    </div>
  );
}

export default CardLesson;
