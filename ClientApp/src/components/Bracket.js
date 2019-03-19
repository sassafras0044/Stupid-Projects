import React from 'react';
import LeftBracket from './LeftBracket';
import RightBracket from './RightBracket';

class Bracket extends React.Component {

    render() {
        return (
            <div>
                <div>
                    <LeftBracket></LeftBracket>
                </div>
                <div>
                    <RightBracket></RightBracket>
                </div>
            </div>
        );
    }
}

export default Bracket;