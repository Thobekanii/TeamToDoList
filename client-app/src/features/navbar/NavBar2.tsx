import React from 'react'
import Navbar from 'react-bootstrap/Navbar'
import { NavLink, Link } from 'react-router-dom';
import { Container, Nav } from 'react-bootstrap'

const NavBar2 = () => {
    return (
        <Navbar bg="light" expand="lg">
            <Navbar.Toggle aria-controls="basic-navbar-nav" />
            <Navbar.Collapse className="justify-content-end">
                <Nav className="mr-auto">
                    <Nav.Link href="/addtask" >ADD TASK</Nav.Link>
                    <Nav.Link href="/">SEARCH TASKS</Nav.Link>
                    <Nav.Link href="/projects">PROJECT</Nav.Link>
                </Nav>
                <Navbar.Text>
                    Signed in as: <a href="#login">Thobekani</a>
                </Navbar.Text>
            </Navbar.Collapse>
        </Navbar>
    )
}
export default NavBar2;