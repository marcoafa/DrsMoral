/*FONT*/
/*BODY*/
/*PRIMARY COLORS*/
/*PRIMARY HOVERS*/
/*NAVIGATION */
* {
  margin: 0;
  padding: 0;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}

body {
  font-family: "Oswald", sans-serif;
  font-size: 18px;
  background: white;
  font-weight: 400;
  font-weight--webkit-font-smoothing: antialiased;
  font-weight-overflow-x: hidden;
  font-weight-max-width: calc(100vh - 40px);
}

.container {
  margin-top: 40px;
}

/*NAV MENU*/
.menu_general {
  top: 0;
  position: fixed;
  height: 40px;
  width: 100%;
  background-color: #3e425b;
  color: #fff;
}
.menu_general li {
  display: inline;
  float: left;
}
.menu_general a {
  display: inline-block;
  width: 100px;
  text-decoration: none;
  text-align: center;
  padding: 10px 0;
  color: #fff;
}
.menu_general a:hover {
  color: #3e425b;
}
.menu_general li:hover {
  background-color: #ddd;
}
.menu_general ul {
  width: calc(100vw - 30%);
  margin: 0 auto;
}

/*HOME*/
#home {
  width: calc(100vw - 30%);
  height: calc(100vh - 40px);
  margin: 0 auto;
}

/*SERVICE*/
#service {
  display: flex;
  width: calc(100vw - 30%);
  height: calc(100vh - 40px);
  align-items: center;
  justify-content: space-around;
  margin: 0 auto;
}

.service_menu {
  width: 30%;
  height: 80%;
}
.service_menu ul {
  list-style: none;
}
.service_menu li {
  width: 100%;
}
.service_menu a {
  display: block;
  text-align: center;
  text-decoration: none;
  text-transform: uppercase;
  color: #3e425b;
  border-right: 2px solid #ddd;
  background-color: white;
  padding: 30px;
}
.service_menu a:hover, .service_menu a.active {
  background: #ddd;
}

.service_info {
  width: 60%;
  height: 80%;
  box-shadow: 0 3px 10px rgba(0, 0, 0, 0.3);
  background-color: #f7f7f7;
}
.service_info h2 {
  text-align: center;
  margin: 20px 30px;
  font-size: 1.5em;
  color: #3e425b;
}
.service_info p {
  text-align: center;
  margin: 20px 30px;
  font-size: 1em;
  text-align: justify;
  color: #3e425b;
  line-height: 2em;
}
.service_info img {
  display: block;
  width: 70%;
  max-height: 270px;
  margin: 0 auto;
}

/*TEAM*/
#team {
  width: calc(100vw - 30%);
  height: calc(100vh - 40px);
  margin: 0 auto;
}

/*CONTACT*/
#contact {
  width: calc(100vw - 30%);
  height: calc(100vh - 40px);
  margin: 0 auto;
}
#contact article {
  width: 100%;
}
#contact article h3 {
  text-align: center;
  width: 100%;
}
#contact article p {
  text-align: center;
  width: 100%;
}
#contact iframe {
  width: 100%;
  height: 30%;
}

#contact_block {
  display: flex;
  width: 100%;
  height: 50%;
}

#contact_form {
  width: 50%;
}
#contact_form input {
  width: 100%;
  border: 1px solid #3e425b;
  background: #aeaeae;
  padding: 10px;
  margin: 0 0 5px;
}

/*# sourceMappingURL=css/contenido.cs.map */
