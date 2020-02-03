import React, { Component, Fragment } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { render } from 'react-dom';
import NavBar from './features/navbar/NavBar';
import TaskForm from './features/form/TaskForm';
import { observer } from 'mobx-react-lite';
import {
  Route,
  withRouter,
  RouteComponentProps,
  Switch
} from 'react-router-dom';
import HomePage from './features/homepage/HomePage';
import { Container } from 'react-bootstrap'
import { ProjectForm } from './features/form/ProjectForm';
import NavBar2 from './features/navbar/NavBar2';

const App: React.FC<RouteComponentProps> = () => {

  return (

    // <NavBar />


    <Fragment> 
      <Container >
        <NavBar />
      </Container>
      <Container style={{ marginTop: '3em' }}>
        <NavBar2 />
      </Container>
      <Container style={{ marginTop: '5em' }}>
        <Switch>
          <Route path={'/(.+)'}
            render={() => (
              <Fragment>
                <Route path='/addtask' component={TaskForm} />
                <Route path='/projects' component={ProjectForm} />
                <Route path='/login' component={HomePage} />
              </Fragment>
            )}
          />
        </Switch>
      </Container>
    </Fragment>

  );
}

export default withRouter(observer(App));

