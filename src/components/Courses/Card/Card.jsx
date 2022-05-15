import "./Card.css";
import React from "react";
import leftRect from "../../../images/rect-left.png";

function Card({ background, img, name, account, time, text }) {
  return (
    <div className="card-container">
      <div
        className="card"
        style={{ backgroundImage: `url(${background})`, borderRadius: "30px" }}
      >
        <div className="top">
          <img src={img} alt="" />
          <p className="name-profile">
            {name} <br></br> {account}
          </p>
          <p className="time">{time}</p>
        </div>
        <div className="bottom">{text}</div>
      </div>
    </div>
  );
}

export default Card;
