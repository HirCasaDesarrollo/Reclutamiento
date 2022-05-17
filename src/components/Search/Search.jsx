import "./Search.css";
import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faMagnifyingGlass,
  faUser,
  faBell,
} from "@fortawesome/free-solid-svg-icons";

function Search() {
  return (
    <div className="search-container">
      <form class="form-inline">
        <FontAwesomeIcon className="lupa icons" icon={faMagnifyingGlass} />
        <input
          className="form-control"
          type="search"
          placeholder="Search..."
          aria-label="Search"
          style={{
            backgroundColor: "#F6F6F5",
            width: "38rem",
            border: "none",
            borderRadius: "10px",
            padding: "0.8rem 3.2rem",
          }}
        ></input>
      </form>
      <FontAwesomeIcon className="icons user-icon" icon={faUser} />
      <FontAwesomeIcon className="bell-icon icons" icon={faBell} />
    </div>
  );
}

export default Search;
