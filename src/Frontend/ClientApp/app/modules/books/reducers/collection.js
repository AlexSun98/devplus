import * as collection from '../actions/collection';
const initialState = {
    loaded: false,
    loading: false,
    ids: [],
};
export function reducer(state = initialState, action) {
    switch (action.type) {
        case collection.LOAD: {
            return Object.assign({}, state, {
                loading: true,
            });
        }
        case collection.LOAD_SUCCESS: {
            const books = action.payload;
            return {
                loaded: true,
                loading: false,
                ids: books.map(book => book.id),
            };
        }
        case collection.ADD_BOOK_SUCCESS:
        case collection.REMOVE_BOOK_FAIL: {
            const book = action.payload;
            if (state.ids.indexOf(book.id) > -1) {
                return state;
            }
            return Object.assign({}, state, {
                ids: [...state.ids, book.id],
            });
        }
        case collection.REMOVE_BOOK_SUCCESS:
        case collection.ADD_BOOK_FAIL: {
            const book = action.payload;
            return Object.assign({}, state, {
                ids: state.ids.filter(id => id !== book.id),
            });
        }
        default: {
            return state;
        }
    }
}
export const getLoaded = (state) => state.loaded;
export const getLoading = (state) => state.loading;
export const getIds = (state) => state.ids;
//# sourceMappingURL=collection.js.map