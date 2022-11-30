declare namespace Test {
    /**
     * The declaration of an enum
     */
    export enum MyEnum {
        A = 0,
        B = 1,
        C = 2,
        D = C
    }

    /**
     * The declaration of an interface
     */
    export interface MyInterface1 {
        /**
         * A method
         */
        testMethod(arg: string, callback: () => void): string;
        /**
         * An event
         * @event
         */
        onTest(listener: (e: MyInterface1) => void): void;
        /**
         * An property
         */
        readonly testProp: string;
    }

    /**
     * Another declaration of an interface
     */
    export interface MyInterface2<T> {
        /**
         * A method
         */
        testMethod(arg: T, callback: () => void): T;
        /**
         * An event
         * @event
         */
        onTest(listener: (e: MyInterface2<T>) => void): void;
        /**
         * An property
         */
        readonly testProp: T;
    }

    /**
     * The declaration of a class
     */
    export class MyClass1<T> implements MyInterface1 {
        /**
         * A method
         */
        testMethod(arg: string, callback: () => void): string;
        /**
         * An event
         * @event
         */
        onTest(listener: (e: MyInterface1) => void): void;
        /**
         * An property
         */
        readonly testProp: string;
        static staticMethod(value: string, isOption?: boolean): UnionStr;
    }

    /**
     * Another declaration of a class
     */
    export class MyClass2<T> implements MyInterface2<T> {
        /**
         * A method
         */
        testMethod(arg: T, callback: () => void): T;
        /**
         * An event
         * @event
         */
        onTest(listener: (e: MyInterface2<T>) => void): void;
        /**
         * An property
         */
        readonly testProp: T;
        static staticMethod(value: string, isOption?: boolean): UnionStr;
    }

    /**
     * The declaration of a type alias
     */
    export type UnionStr = "A" | "B" | "C" | "other";
}