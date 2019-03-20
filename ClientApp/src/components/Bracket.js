import React from 'react';
import LeftBracket from './LeftBracket';
import RightBracket from './RightBracket';

class Bracket extends React.Component {

    render() {
        return (
            <div style={{"margin" : "40px"}}>
                <div style={{"width" : "800px", "float" : "left"}}>
                    <LeftBracket></LeftBracket>
                </div>
                <div style={{ "width": "800px", "float" : "right" }}>
                    <RightBracket></RightBracket>
                </div>
            </div>
        );
    }
}

export default Bracket;