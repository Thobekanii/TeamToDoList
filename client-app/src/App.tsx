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

const App: React.FC<RouteComponentProps> = () => {

  return (

    // <NavBar />


    <Fragment>
      <NavBar />

      <Container style={{ marginTop: '7em' }}>
        <Route path='/' component={HomePage} />
        <Switch>
          <Route path={'/(.+)'}
            render={() => (
              <Fragment>
                <Route path='/addtask' component={TaskForm} />
              </Fragment>
            )}
            />
        </Switch>
      </Container>
      </Fragment>

      );
    }
    
    export default withRouter(observer(App));
    
