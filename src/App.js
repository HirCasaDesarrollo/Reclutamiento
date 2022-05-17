import "./App.css";
import React from "react";
import Sidebar from "./components/sidebar/Sidebar";
import Search from "./components/Search/Search";
import Courses from "./components/Courses/Courses";
import Lessons from "./components/Lessons/Lesssons";

function App() {
  return (
    <div className="container-x ">
      <Sidebar />
      <div className="content ">
        <Search />
        <Courses />
        <Lessons />
      </div>
    </div>
  );
}

export default App;
