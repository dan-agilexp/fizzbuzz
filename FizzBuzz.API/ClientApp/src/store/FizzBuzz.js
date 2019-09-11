const receiveFizzBuzz = 'RECEIVE_FIZZBUZZ';
const initialState = { fizzBuzzResponse : "", isLoading: false };

export const actionCreators = {
    requestFizzBuzz: inputNumber => async (dispatch, getState) => {
        const url = `api/FizzBuzz/${inputNumber}`;
        const response = await fetch(url);
        const result = await response.text();
        dispatch({ type: receiveFizzBuzz, payload: result });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === receiveFizzBuzz) {
        return {
            ...state,
            fizzBuzzResponse: action.payload,
            isLoading: true
        };
    }

    return state;
};