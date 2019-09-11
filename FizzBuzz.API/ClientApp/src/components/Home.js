import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/FizzBuzz';

class Home extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            input: ""
        }
    }

    onChange = (value) => {
        this.setState({
            input: value
        });
    }

    render() {
        return (
            <div>
                <h1>FizzBuzz</h1>
                    <input type="text" onChange={(e) => this.onChange(e.target.value)} />
                    <p>The <code>ClientApp</code> subdirectory is a standard React application based on the <code>create-react-app</code> template. If you open a command prompt in that directory, you can run <code>npm</code> commands such as <code>npm test</code> or <code>npm install</code>.</p>
                    <input onClick={() => this.props.requestFizzBuzz(this.state.input)} type="button" value="Submit" />
                <div>
                    {this.props.fizzBuzzResponse}
                </div>
            </div>
            );
    }
};

export default connect(
    state => state.fizzBuzz,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Home);
